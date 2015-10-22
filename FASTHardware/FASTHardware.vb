Imports System.IO.Ports
Imports System.Threading

Public Class FASTHardware
    Public Event HardwareChanged()
    Public Event DebugMessage(ByVal Message As String)
    Public Event SwitchChanged(ByVal sender As FASTSwitch, ByVal e As FASTSwitchStateChangedArgs)

    Private WithEvents _RGBPort As FASTRGBPort
    Private WithEvents _NETPort As FASTNETPort
    Private WithEvents _DMDPort As FASTDMDPort

    Public ReadOnly Property HasNET As Boolean
        Get
            If _NETPort IsNot Nothing Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property NET As FASTNETPort
        Get
            Return _NETPort
        End Get
    End Property

    Public ReadOnly Property HasDMD As Boolean
        Get
            If _DMDPort IsNot Nothing Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property DMD As FASTDMDPort
        Get
            Return _DMDPort
        End Get
    End Property

    Public ReadOnly Property HasRGB As Boolean
        Get
            If _RGBPort IsNot Nothing Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property RGB As FASTRGBPort
        Get
            Return _RGBPort
        End Get
    End Property

    Public ReadOnly Property Ports As List(Of FASTPort)
        Get
            Dim _Ports As New List(Of FASTPort)
            If _NETPort IsNot Nothing Then
                _Ports.Add(_NETPort)
            End If
            If _RGBPort IsNot Nothing Then
                _Ports.Add(_RGBPort)
            End If
            If _DMDPort IsNot Nothing Then
                _Ports.Add(_DMDPort)
            End If
            Return _Ports
        End Get
    End Property

    Public Sub New()
        _RGBPort = Nothing
        _NETPort = Nothing
    End Sub

    Public Sub AutoConfigurePorts()
        Dim _TempPort As SerialPort = Nothing

        Dim _PortCount As Integer = My.Computer.Ports.SerialPortNames.Count
        If _PortCount = 0 Then
            Throw New Exception("No Serial Ports Found On This Computer")
        End If

        For Each _Port As String In My.Computer.Ports.SerialPortNames
            Try
                _TempPort = My.Computer.Ports.OpenSerialPort(_Port, 921600)
                _TempPort.ReadTimeout = 250
                _TempPort.NewLine = vbCr
                _TempPort.Encoding = System.Text.Encoding.UTF8
                _TempPort.Write("ID:" & vbCr)
                Dim _ReturnValue As String = ""
                'For _CharCount As Integer = 0 To 26
                '    If _CharCount = 25 Then Stop
                '    Dim _Char As String = _TempPort.ReadByte
                'Next
                _ReturnValue = _TempPort.ReadLine()
                If _ReturnValue.StartsWith("ID:RGB FP-CPU") Then
                    Dim _NewPort As New FASTRGBPort
                    _NewPort.Port = _TempPort
                    _NewPort.RawIDString = _ReturnValue
                    _RGBPort = _NewPort
                ElseIf _ReturnValue.StartsWith("ID:NET FP-CPU") Then
                    Dim _NewPort As New FASTNETPort
                    _NewPort.Port = _TempPort
                    _NewPort.RawIDString = _ReturnValue
                    _NETPort = _NewPort
                ElseIf _ReturnValue.StartsWith("ID:DMD FP-CPU") Then
                    Dim _NewPort As New FASTDMDPort
                    _NewPort.Port = _TempPort
                    _NewPort.RawIDString = _ReturnValue
                    _DMDPort = _NewPort
                Else
                    MsgBox(_ReturnValue.ToString(), MsgBoxStyle.MsgBoxRight, "Unknown CPU Detected")
                End If
            Catch ex As Exception
                'FUCK YO COUCH
            Finally
                If _TempPort IsNot Nothing Then
                    If _TempPort.IsOpen Then
                        _TempPort.Close()
                    End If
                End If
            End Try
        Next

        If HasNET Then
            'Grab the nodes from the net
            _NETPort.DiscoverNodes()

            'Figure out the switch counts
            _NETPort.DiscoverSwitches()
        End If

        RaiseEvent HardwareChanged()
    End Sub

    Private Sub _NETPort_SwitchStateChanged(sender As Object, e As FASTSwitchStateChangedArgs) Handles _NETPort.SwitchStateChanged
        RaiseEvent SwitchChanged(sender, e)
        'RaiseEvent DebugMessage("Switch " & CType(sender, FASTSwitch).DisplayName & " " & IIf(CType(sender, FASTSwitch).Closed, "Closed", "Opened"))
    End Sub
End Class
