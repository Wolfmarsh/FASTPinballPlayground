Public Class FASTNETPort
    Inherits FASTPort

    Public Event SwitchStateChanged(ByVal sender As System.Object, ByVal e As FASTSwitchStateChangedArgs)

    Public Overrides ReadOnly Property PortType As FASTPort.eFASTPortType
        Get
            Return eFASTPortType.NET
        End Get
    End Property

    Public Property NetworkSwitchCount As Integer
    Public Property Nodes As List(Of FASTNode)
    Public Property Switches As List(Of FASTSwitch)
    Public Property Drivers As List(Of FASTDriver)

    Public Sub New()
        MyBase.New()

        _Nodes = New List(Of FASTNode)
        _Switches = New List(Of FASTSwitch)
        _Drivers = New List(Of FASTDriver)
    End Sub

    Public Sub DiscoverNodes()
        Dim _RawNodeConfig As String = SendRawMessage("CN:")

        Dim _Lines() As String = _RawNodeConfig.Split(vbCrLf)

        For Each _Line As String In _Lines
            If _Line.StartsWith("NN:") Then
                Dim _NewNode As New FASTNode
                _NewNode.RawConfigLine = _Line
                _Nodes.Add(_NewNode)
            End If
        Next
    End Sub

    Public Sub DiscoverDrivers()
        _Drivers.Clear()
        Dim _RawNodeConfig As String = SendRawMessage("CD:")

        Dim _Lines() As String = _RawNodeConfig.Split(vbCrLf)

        For Each _Line As String In _Lines
            If _Line.StartsWith("DN:") Then
                Dim _NewDriver As New FASTDriver
                _NewDriver.RawConfigLine = _Line
                _Drivers.Add(_NewDriver)
            End If
        Next
    End Sub

    Public Sub DiscoverSwitches()
        If PortType <> eFASTPortType.NET Then
            Throw New Exception("Can Only DiscoverNodes on a NET Port")
        End If

        Dim _RawSwitchConfig As String = SendRawMessage("SA:")
        _RawSwitchConfig = _RawSwitchConfig.Replace("SA:", "")
        Dim _SwitchConfigPieces() As String = _RawSwitchConfig.Split(",")

        NetworkSwitchCount = (Convert.ToInt32(_SwitchConfigPieces(2), 16) - 1) * 8

        For _SwitchCount As Integer = 0 To NetworkSwitchCount - 1
            Dim _NewSwitch As New FASTSwitch(_SwitchCount.ToString())
            AddSwitch(_NewSwitch)
        Next

    End Sub

    Public Sub AddSwitch(ByVal NewSwitch As FASTSwitch)
        AddHandler NewSwitch.SwitchStateChanged, AddressOf GenericSwitchHandler
        _Switches.Add(NewSwitch)

    End Sub

    Private Sub GenericSwitchHandler(ByVal sender As System.Object, ByVal e As FASTSwitchStateChangedArgs)
        RaiseEvent SwitchStateChanged(sender, e)
    End Sub

    Public Overrides Sub ProcessMessage(LineToProcess As String)
        Try
            Dim _LineParts() As String = LineToProcess.Split(":")
            Dim _SwitchNumber As Integer = Convert.ToInt32(_LineParts(1), 16)
            Select Case _LineParts(0)
                Case "-N"
                    _Switches.Item(_SwitchNumber).Closed = True
                Case "/N"
                    _Switches.Item(_SwitchNumber).Closed = False
                Case Else
                    MsgBox("Unrecognized Message" & vbCrLf & """" & LineToProcess & """")
            End Select
        Catch ex As Exception
            MsgBox("Error Processing (" & LineToProcess & ")" & vbCrLf & ex.Message)
        End Try
    End Sub
End Class
