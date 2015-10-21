Imports FASTHardware
Public Class MainForm

    Private WithEvents _FAST As New FASTHardware.FASTHardware

    Delegate Sub SwitchChangedDelegate(sender As Object, e As FASTSwitchStateChangedArgs)
    Private _SwitchChangedDelegate As SwitchChangedDelegate

    Delegate Sub MyGUIUpdateDelegate(ByVal Message As String)
    Public _myGUIUpdateDelegate As MyGUIUpdateDelegate

    Private Sub btn_port_autoconfig_Click(sender As Object, e As EventArgs) Handles btn_port_autoconfig.Click
        Try
            _FAST.AutoConfigurePorts()
        Catch ex As Exception
            If ex.Message = "No Serial Ports Found On This Computer" Then
                MsgBox("No Serial Ports Were Found On This Computer", MsgBoxStyle.OkOnly, "No Ports Found")
                Exit Sub
            Else
                Throw ex
            End If
        End Try
    End Sub

    Private Sub btn_rgb_changecolor_Click(sender As Object, e As EventArgs) Handles btn_rgb_changecolor.Click
        Dim _ColorForm As New ColorDialog
        _ColorForm.Color = pnl_color.BackColor
        _ColorForm.ShowDialog()
        pnl_color.BackColor = _ColorForm.Color
    End Sub

    Private Sub btn_rgb_setallleds_Click(sender As Object, e As EventArgs) Handles btn_rgb_setallleds.Click
        _FAST.RGB.SetAllRGBLEDs(pnl_color.BackColor)
    End Sub

    Private Sub btn_rgb_fadeallleds_Click(sender As Object, e As EventArgs) Handles btn_rgb_fadeallleds.Click
        Dim _FadeAnimation As New RGBAnimation
        _FadeAnimation.AddFrames(RGBAnimation.GenerateAllLEDFade(System.Drawing.Color.Black, pnl_color.BackColor, 500))
        _FadeAnimation.AddFrames(RGBAnimation.GenerateAllLEDFade(pnl_color.BackColor, System.Drawing.Color.Black, 500))
        _FadeAnimation.Repeat = True
        _FAST.RGB.PlayRGBAnimation(_FadeAnimation)
    End Sub

    Public Sub GUISwitchChangeHandler(sender As FASTSwitch, e As FASTSwitchStateChangedArgs)
        If (Me.InvokeRequired) Then
            Me.Invoke(_myGUIUpdateDelegate)
        Else
            If tc_areas.SelectedTab.Text = "Switches" Then
                txt_switches_activity.AppendText(GetTimeStamp() & ": " & sender.DisplayName & " " & IIf(sender.Closed, "Closed", "Opened") & vbCrLf)
                If sender.Closed Then
                    My.Computer.Audio.Play(My.Resources.switchbeepon, AudioPlayMode.Background)
                Else
                    My.Computer.Audio.Play(My.Resources.switchbeepoff, AudioPlayMode.Background)
                End If
                dg_switches_switchlist.Refresh()
            End If
        End If
    End Sub

    Private Function GetTimeStamp() As String
        Return DateTime.Now.ToString("HH:mm:ss.fffffff")
    End Function

    Private Sub _FAST_HardwareChanged() Handles _FAST.HardwareChanged
        dg_hardware_ports.DataSource = Nothing
        dg_hardware_ports.AutoGenerateColumns = False
        dg_hardware_ports.DataSource = _FAST.Ports

        cb_terminal_port.DataSource = _FAST.Ports

        dg_hardware_nodes.DataSource = Nothing
        dg_hardware_nodes.AutoGenerateColumns = False
        dg_hardware_nodes.DataSource = _FAST.NET.Nodes

        lbl_hardware_networkswitchcount.Text = _FAST.NET.NetworkSwitchCount

        dg_switches_switchlist.DataSource = Nothing
        dg_switches_switchlist.AutoGenerateColumns = False
        dg_switches_switchlist.DataSource = _FAST.NET.Switches
    End Sub

    Private Sub btn_terminal_sendcustom_Click(sender As Object, e As EventArgs) Handles btn_terminal_sendcustom.Click
        Dim _Return As String = CType(cb_terminal_port.SelectedItem, FASTPort).SendRawMessage(txt_terminal_command.Text)
        txt_terminal_console.Text = _Return.Replace(vbCr, vbCrLf)
    End Sub

    Private Sub tc_areas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tc_areas.SelectedIndexChanged
        If tc_areas.SelectedTab.Text = "Switches" Then
            _FAST.NET.StartListener()
        Else
            _FAST.NET.StopListener()
        End If

        'MsgBox(tc_areas.SelectedTab.Text)

    End Sub

    Private Sub _FAST_SwitchChanged(sender As FASTSwitch, e As FASTSwitchStateChangedArgs) Handles _FAST.SwitchChanged
        _SwitchChangedDelegate = New SwitchChangedDelegate(AddressOf GUISwitchChangeHandler)
        Invoke(_SwitchChangedDelegate, {sender, e})
    End Sub

    Private Sub btn_rgb_stopfadeall_Click(sender As Object, e As EventArgs) Handles btn_rgb_stopfadeall.Click
        _FAST.RGB.StopAllAnimations()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = Me.Text & " - " & Application.ProductVersion
    End Sub
End Class
