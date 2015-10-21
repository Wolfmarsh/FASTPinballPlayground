Public Class RGBAnimation
    Public Property Repeat As Boolean

    Private _Frames As List(Of RGBFrame)
    Private _CurrentFrameIndex As Integer = 0

    Public Sub New()
        _Frames = New List(Of RGBFrame)
        _Repeat = False
    End Sub

    Public Sub AddFrames(ByVal FramesToAdd As List(Of RGBFrame))
        _Frames.AddRange(FramesToAdd)
    End Sub

    Public Function GetNextFrame() As RGBFrame
        If _CurrentFrameIndex >= _Frames.Count Then
            If Repeat Then
                _CurrentFrameIndex = 1
                Return _Frames(0)
            Else
                Return Nothing
            End If
        Else
            _CurrentFrameIndex += 1
            Return _Frames(_CurrentFrameIndex - 1)
        End If
    End Function

    Public Shared Function GenerateAllLEDFade(ByVal StartColor As System.Drawing.Color, ByVal EndColor As System.Drawing.Color, ByVal FadeDuration As Integer) As List(Of RGBFrame)
        Dim _FadeFrames As New List(Of RGBFrame)

        Dim _FrameDuration As Integer = 33 'in ms.  

        Dim _FrameCount As Integer = FadeDuration / _FrameDuration

        Dim _RStep As Integer = (CInt(EndColor.R) - CInt(StartColor.R)) / _FrameCount
        Dim _GStep As Integer = (CInt(EndColor.G) - CInt(StartColor.G)) / _FrameCount
        Dim _BStep As Integer = (CInt(EndColor.B) - CInt(StartColor.B)) / _FrameCount

        For _FrameNum As Integer = 0 To _FrameCount '
            Dim _NewFrame As New RGBFrame
            _NewFrame.Duration = _FrameDuration
            _NewFrame.FrameLEDs.Add(New RGBFrameLED With {.R = StartColor.R + (_FrameNum * _RStep), .G = StartColor.G + (_FrameNum * _GStep), .B = StartColor.B + (_FrameNum * _BStep), .LEDNumber = 50000})
            _FadeFrames.Add(_NewFrame)
        Next

        Return _FadeFrames
    End Function

End Class
