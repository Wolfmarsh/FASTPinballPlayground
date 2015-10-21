Public Class RGBFrame

    Public Property Duration As Integer
    Public Property FrameLEDs As List(Of RGBFrameLED)

    Public Sub New()
        _FrameLEDs = New List(Of RGBFrameLED)
    End Sub
End Class
