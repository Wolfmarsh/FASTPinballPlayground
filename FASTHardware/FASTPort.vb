Imports System.IO.Ports
Imports System.Text

Public MustInherit Class FASTPort
    Public Enum eFASTPortType
        Unknown = 0
        NET
        RGB
        DMD
    End Enum

#Region "Properties"
    Public ReadOnly Property HardwareName As String
        Get
            Select Case PortType
                Case eFASTPortType.NET
                    Return "FAST NET Controller"
                Case eFASTPortType.RGB
                    Return "FAST RGB Controller"
                Case eFASTPortType.DMD
                    Return "FAST DMD Controller"
                Case Else
                    Return _RawIDString
            End Select
        End Get
    End Property

    Public ReadOnly Property HardwareVersion As String
        Get
            Return Split(_RawIDString, " ")(2)
        End Get
    End Property

    Public ReadOnly Property IsListening() As Boolean
        Get
            Return _IsListening
        End Get
    End Property

    Public Property Port As SerialPort
        Get
            Return _Port
        End Get
        Set(value As SerialPort)
            _Port = value
        End Set
    End Property

    Public ReadOnly Property PortName As String
        Get
            If _Port IsNot Nothing Then
                Return _Port.PortName
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public MustOverride ReadOnly Property PortType As eFASTPortType

    Public Property RawIDString As String

#End Region

    Private _IsListening As Boolean
    Private WithEvents _Port As SerialPort

    Public Sub New()

    End Sub


    Public Sub StartListener()
        If Not _Port.IsOpen Then
            _Port.Open()
        End If

        AddHandler _Port.DataReceived, AddressOf _Port_DataReceived
        _IsListening = True
    End Sub

    Public Sub StopListener()
        _IsListening = False
        If _Port.IsOpen Then
            _Port.Close()
        End If
        RemoveHandler _Port.DataReceived, AddressOf _Port_DataReceived
    End Sub


    Public Function SendRawMessage(ByVal Message As String, Optional ByVal ReadAnything As Boolean = True) As String
        Dim _ReturnValue As New StringBuilder

        If Not _Port.IsOpen Then
            _Port.Open()
        End If

        _Port.Write(Message & vbCr)

        If ReadAnything Then
            For _TimeoutCounter As Integer = 0 To 5
                Dim _Data As String = ""
                _Data = _Port.ReadExisting()
                If String.IsNullOrEmpty(_Data) Then
                    Threading.Thread.Sleep(50)
                Else
                    _ReturnValue.Append(_Data)
                End If
            Next
        End If

        'If Not LeaveOpen Then
        '    If _Port.IsOpen Then
        '        _Port.Close()
        '    End If
        'End If

        Return _ReturnValue.ToString()
    End Function

    Overridable Sub ProcessMessage(ByVal LineToProcess As String)

    End Sub

    Private Sub _Port_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)
        Dim _IncomingLine As String = _Port.ReadLine()
        ProcessMessage(_IncomingLine)
    End Sub
End Class
