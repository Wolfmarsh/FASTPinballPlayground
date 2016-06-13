Imports System.Threading

Public Class FASTRGBPort
    Inherits FASTPort

    Private _PlayingRGBAnimations As List(Of Thread)

    Public Sub New()
        MyBase.New()
        _PlayingRGBAnimations = New List(Of Thread)
    End Sub
    Public Overrides ReadOnly Property PortType As FASTPort.eFASTPortType
        Get
            Return eFASTPortType.RGB
        End Get
    End Property

    Public Sub SetRGBLED(ByVal LEDNumber As Integer, ByVal Color As System.Drawing.Color)
        SendRawMessage("RS:" & LEDNumber.ToString("x2") & Color.R.ToString("x2") & Color.G.ToString("x2") & Color.B.ToString("x2"), False)
    End Sub

    Public Sub SetAllRGBLEDs(ByVal Color As System.Drawing.Color)
        SendRawMessage("RA:" & Color.R.ToString("x2") & Color.G.ToString("x2") & Color.B.ToString("x2"), False)
    End Sub

    Public Sub StopAllAnimations()
        For Each _Thread As Thread In _PlayingRGBAnimations
            _Thread.Abort()
        Next
    End Sub

    Public Sub PlayRGBAnimation(ByVal AnimationToPlay As RGBAnimation)
        Dim _PlayThread As New Thread(AddressOf ExecuteAnimation)
        _PlayThread.Start(AnimationToPlay)
        _PlayingRGBAnimations.Add(_PlayThread)
    End Sub

    Private Sub ExecuteAnimation(ByVal AnimationToPlay As RGBAnimation)
        Dim _NextFrame As RGBFrame = AnimationToPlay.GetNextFrame()
        While AnimationToPlay.GetNextFrame IsNot Nothing
            For Each _FrameLED As RGBFrameLED In _NextFrame.FrameLEDs
                Select Case _FrameLED.LEDNumber
                    Case 50000
                        SendRawMessage("RA:" & _FrameLED.R.ToString("x2") & _FrameLED.G.ToString("x2") & _FrameLED.B.ToString("x2"), False)
                    Case Else
                        'When you come to debug here, its missing the leading 0 in the led number, i was too lazy at the time to look it up, which would have taken as long as typing this comment did
                        SendRawMessage("RS:" & _FrameLED.LEDNumber.ToString() & _FrameLED.R.ToString("x2") & _FrameLED.G.ToString("x2") & _FrameLED.B.ToString("x2"), False)
                End Select
            Next

            'This sleep needs to only happen for the duration minus the time it took to get here, not the full duration.
            Threading.Thread.Sleep(_NextFrame.Duration)
            _NextFrame = AnimationToPlay.GetNextFrame()
        End While
    End Sub
End Class
