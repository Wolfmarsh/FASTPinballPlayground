Imports FASTHardware
Public Class MainForm

    Private WithEvents _FAST As New FASTHardware.FASTHardware

    Delegate Sub SwitchChangedDelegate(sender As Object, e As FASTSwitchStateChangedArgs)
    Private _SwitchChangedDelegate As SwitchChangedDelegate

    Delegate Sub MyGUIUpdateDelegate(ByVal Message As String)
    Public _myGUIUpdateDelegate As MyGUIUpdateDelegate

    Private _Speech As System.Speech.Synthesis.SpeechSynthesizer
    Private _SwitchList As List(Of String)

    Private Sub btn_port_autoconfig_Click(sender As Object, e As EventArgs) Handles btn_port_autoconfig.Click
        Try
            btn_port_autoconfig.Enabled = False
            lbl_scanning.Visible = True
            _FAST.AutoConfigurePorts()
            DisplayHardwareControls(True)
            lbl_scanning.Visible = False
            btn_port_autoconfig.Enabled = True
            MsgBox("Complete", MsgBoxStyle.OkOnly, "Scan Complete")
        Catch ex As Exception
            lbl_scanning.Visible = False
            btn_port_autoconfig.Enabled = True
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
        If _FAST.HasRGB Then
            _FAST.RGB.SetAllRGBLEDs(pnl_color.BackColor)
        End If
    End Sub

    Private Sub btn_rgb_fadeallleds_Click(sender As Object, e As EventArgs) Handles btn_rgb_fadeallleds.Click
        If _FAST.HasRGB Then
            Dim _FadeAnimation As New RGBAnimation
            _FadeAnimation.AddFrames(RGBAnimation.GenerateAllLEDFade(System.Drawing.Color.Black, pnl_color.BackColor, 500))
            _FadeAnimation.AddFrames(RGBAnimation.GenerateAllLEDFade(pnl_color.BackColor, System.Drawing.Color.Black, 500))
            _FadeAnimation.Repeat = True
            _FAST.RGB.PlayRGBAnimation(_FadeAnimation)
        End If
    End Sub

    Public Sub GUISwitchChangeHandler(sender As FASTSwitch, e As FASTSwitchStateChangedArgs)
        If (Me.InvokeRequired) Then
            Me.Invoke(_myGUIUpdateDelegate)
        Else
            If tc_areas.SelectedTab.Text = "Switches" Then
                txt_switches_activity.Text = GetTimeStamp() & ": " & sender.DisplayName & " " & IIf(sender.Closed, "Closed", "Opened") & vbCrLf & txt_switches_activity.Text
                If (txt_switches_activity.Text.Length > 500) Then
                    txt_switches_activity.Text = txt_switches_activity.Text.Substring(0, txt_switches_activity.Text.LastIndexOf(vbCrLf, txt_switches_activity.Text.LastIndexOf(vbCrLf) - 1))
                End If

                If sender.Closed Then
                    lbl_recent_switch.Text = sender.DisplayName & " CLOSED"
                    If chk_use_tts.Checked Then
                        _Speech.SpeakAsync(sender.DisplayName & " CLOSED")
                    Else
                        My.Computer.Audio.Play(My.Resources.switchbeepon, AudioPlayMode.Background)
                    End If
                Else
                    lbl_recent_switch.Text = sender.DisplayName & " OPEN"
                    If chk_use_tts.Checked Then
                        _Speech.SpeakAsync(sender.DisplayName & " OPEN")
                    Else
                        My.Computer.Audio.Play(My.Resources.switchbeepoff, AudioPlayMode.Background)
                    End If
                End If
                dg_switches_switchlist.Refresh()
            End If
        End If
    End Sub

    Private Function GetTimeStamp() As String
        Return DateTime.Now.ToString("HH:mm:ss.ff")
    End Function

    Private Sub _FAST_HardwareChanged() Handles _FAST.HardwareChanged

        dg_hardware_ports.DataSource = Nothing
        dg_hardware_ports.AutoGenerateColumns = False
        dg_hardware_ports.DataSource = _FAST.Ports

        cb_terminal_port.DataSource = _FAST.Ports

        If _FAST.HasNET Then
            dg_hardware_nodes.DataSource = Nothing
            dg_hardware_nodes.AutoGenerateColumns = False
            dg_hardware_nodes.DataSource = _FAST.NET.Nodes

            lbl_hardware_networkswitchcount.Text = _FAST.NET.NetworkSwitchCount

            dg_switches_switchlist.DataSource = Nothing
            dg_switches_switchlist.AutoGenerateColumns = False
            dg_switches_switchlist.DataSource = _FAST.NET.Switches

            lst_Drivers.DataSource = Nothing
            lst_Drivers.DataSource = _FAST.NET.Drivers
        End If

    End Sub

    Private Sub btn_terminal_sendcustom_Click(sender As Object, e As EventArgs) Handles btn_terminal_sendcustom.Click
        SendTerminalCommand(txt_terminal_command.Text, cb_terminal_includecr.Checked)
    End Sub

    Private Sub tc_areas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tc_areas.SelectedIndexChanged
        If IsNothing(_FAST.NET) = False Then 'Make sure object is initialized
            If tc_areas.SelectedTab.Text = "Switches" Then
                _FAST.NET.StartListener()
            Else
                _FAST.NET.StopListener()
            End If
        End If

    End Sub

    Private Sub _FAST_SwitchChanged(sender As FASTSwitch, e As FASTSwitchStateChangedArgs) Handles _FAST.SwitchChanged
        _SwitchChangedDelegate = New SwitchChangedDelegate(AddressOf GUISwitchChangeHandler)
        Invoke(_SwitchChangedDelegate, {sender, e})
    End Sub

    Private Sub btn_rgb_stopfadeall_Click(sender As Object, e As EventArgs) Handles btn_rgb_stopfadeall.Click
        If _FAST.HasRGB Then
            _FAST.RGB.StopAllAnimations()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = Me.Text & " - " & Application.ProductVersion
        DisplayHardwareControls(False)
        cb_pulse_pwm.SelectedIndex = 3

        _Speech = New System.Speech.Synthesis.SpeechSynthesizer()
        _Speech.SetOutputToDefaultAudioDevice()
    End Sub

    Private Sub DisplayHardwareControls(ByVal isHardwareDetected As Boolean)
        Label3.Visible = isHardwareDetected
        Label4.Visible = isHardwareDetected
        Label4.Visible = isHardwareDetected
        Label5.Visible = isHardwareDetected
        dg_hardware_ports.Visible = isHardwareDetected
        dg_hardware_nodes.Visible = isHardwareDetected
        lbl_hardware_networkswitchcount.Visible = isHardwareDetected
    End Sub

    Private Sub dg_switches_switchlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_switches_switchlist.CellContentClick

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txt_terminal_command_TextChanged(sender As Object, e As EventArgs) Handles txt_terminal_command.TextChanged

    End Sub

    Private Sub txt_terminal_command_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_terminal_command.KeyPress
        If e.KeyChar = vbCr Then
            SendTerminalCommand(txt_terminal_command.Text, cb_terminal_includecr.Checked)
        End If
    End Sub

    Private Sub SendTerminalCommand(terminalCommand As String, Optional IncludeCR As Boolean = True)
        If _FAST.HasNET Then
            Dim _Return As String = CType(cb_terminal_port.SelectedItem, FASTPort).SendRawMessage(terminalCommand, IncludeCR:=IncludeCR)
            txt_terminal_console.Text = _Return.Replace(vbCr, vbCrLf)
        End If
    End Sub



    Private Sub lst_Drivers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Drivers.SelectedIndexChanged
        Dim DriverName As String
        DriverName = lst_Drivers.Text()
        _FAST.NET.DiscoverDrivers() 'Refresh
        Dim f As New FASTDriver
        f = _FAST.NET.Drivers.Find(Function(p) p.ID = DriverName)
        BindListView(f)
    End Sub

    Private Sub BindListView(singleDriver As FASTDriver)
        Dim lvi As ListViewItem
        lv_DriverInformation.Items.Clear()


        For Each p As System.Reflection.PropertyInfo In singleDriver.GetType().GetProperties()
            If p.CanRead Then
                lvi = lv_DriverInformation.Items.Add(p.Name)
                lvi.SubItems.Add(p.GetValue(singleDriver, Nothing))
            End If
        Next
    End Sub

    Private Sub btn_ExecuteDriver_Click(sender As Object, e As EventArgs) Handles btn_ExecuteDriver.Click
        'Example from mpf - thanks jan
        'cmd = '{}{},89,00,10,{},{},00,00,{}'.format(
        '        self.get_config_cmd(),
        '        self.number,
        '        hex_ms_string,
        '        self.get_pwm_for_cmd(pulse_settings.power),
        '        self.get_recycle_ms_for_cmd(self.config.default_recycle, pulse_settings.duration)
        '    )
        'DN:04,89,00,10,10,AA,50
        Dim _ms As Integer
        _ms = num_pulse_ms.Value
        Dim _mshex As String
        _mshex = _ms.ToString("X2")

        '12.5
        '25
        '37.5
        '50
        '62.5
        '75
        '87.5
        '100
        Dim _pwmhex As String
        Select Case cb_pulse_pwm.SelectedText
            Case "12.5"
                _pwmhex = "01"
            Case "25"
                _pwmhex = "88"
            Case "37.5"
                _pwmhex = "92"
            Case "50"
                _pwmhex = "AA"
            Case "62.5"
                _pwmhex = "BA"
            Case "75"
                _pwmhex = "EE"
            Case "87.5"
                _pwmhex = "FE"
            Case "100"
                _pwmhex = "FF"
            Case Else
                _pwmhex = "AA"
        End Select

        SendTerminalCommand(lst_Drivers.Text() & ",89,00,10," & _mshex & "," & _pwmhex & ",50")
    End Sub

    Private Sub btn_SetLED_Click(sender As Object, e As EventArgs) Handles btn_SetLED.Click
        If _FAST.HasRGB Then
            _FAST.RGB.SetRGBLED(num_LEDNumber.Value, pnl_color2.BackColor)
        End If
    End Sub

    Private Sub btn_rgb_changecolor2_Click(sender As Object, e As EventArgs) Handles btn_rgb_changecolor2.Click
        Dim _ColorForm As New ColorDialog
        _ColorForm.Color = pnl_color2.BackColor
        _ColorForm.ShowDialog()
        pnl_color2.BackColor = _ColorForm.Color
    End Sub

    Private Sub btn_comm_id_Click(sender As Object, e As EventArgs) Handles btn_comm_id.Click
        If _FAST.HasNET Then
            Dim _Return As String = CType(cb_terminal_port.SelectedItem, FASTPort).SendRawMessage("ID:", True)
            txt_terminal_console.Text = _Return.Replace(vbCr, vbCrLf)
        End If
    End Sub

    Private Sub btn_comm_cn_Click(sender As Object, e As EventArgs) Handles btn_comm_cn.Click
        If _FAST.HasNET Then
            Dim _Return As String = CType(cb_terminal_port.SelectedItem, FASTPort).SendRawMessage("CN:", True)
            txt_terminal_console.Text = _Return.Replace(vbCr, vbCrLf)
        End If
    End Sub

    Private Sub btn_comm_sa_Click(sender As Object, e As EventArgs) Handles btn_comm_sa.Click
        If _FAST.HasNET Then
            Dim _Return As String = CType(cb_terminal_port.SelectedItem, FASTPort).SendRawMessage("SA:", True)
            txt_terminal_console.Text = _Return.Replace(vbCr, vbCrLf)
        End If
    End Sub

    Private Sub btn_comm_wd0_Click(sender As Object, e As EventArgs) Handles btn_comm_wd0.Click
        If _FAST.HasNET Then
            Dim _Return As String = CType(cb_terminal_port.SelectedItem, FASTPort).SendRawMessage("WD:0", True)
            txt_terminal_console.Text = _Return.Replace(vbCr, vbCrLf)
        End If
    End Sub
End Class
