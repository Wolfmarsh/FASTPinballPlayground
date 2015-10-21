<Serializable()> _
Public Class RGBTrackFrame
    Implements ICloneable

    Public Function Clone() As Object Implements ICloneable.Clone
        Return New RGBTrackFrame(_R, _G, _B) With {.FrameID = Me.FrameID, .ParentTrack = Me.ParentTrack}
    End Function

    Private _R As Integer
    Private _G As Integer
    Private _B As Integer

    Public Property FrameID As Guid

    Public ReadOnly Property FrameDisplayName As String
        Get
            Return ParentTrack.PositionDisplayName(Me)
        End Get
    End Property

    Public ReadOnly Property TrackIndex As Integer
        Get
            Return ParentTrack.GetFrameIndex(Me)
        End Get
    End Property

    Public Property ParentTrack As RGBTrack

    Public ReadOnly Property RGBColor As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(_R, _G, _B)
        End Get
    End Property

    <System.ComponentModel.Category("RGBColor")> _
    Public Property R As Integer
        Get
            Return _R
        End Get
        Set(value As Integer)
            _R = value
        End Set
    End Property

    <System.ComponentModel.Category("RGBColor")> _
    Public Property G As Integer
        Get
            Return _G
        End Get
        Set(value As Integer)
            _G = value
        End Set
    End Property

    <System.ComponentModel.Category("RGBColor")> _
    Public Property B As Integer
        Get
            Return _B
        End Get
        Set(value As Integer)
            _B = value
        End Set
    End Property

    Public Sub New()
        _R = 0
        _G = 0
        _B = 0

        _FrameID = System.Guid.NewGuid
    End Sub

    Public Sub New(ByVal RValue As Integer, ByVal GValue As Integer, ByVal BValue As Integer)
        _R = RValue
        _G = GValue
        _B = BValue

        _FrameID = System.Guid.NewGuid
    End Sub
End Class
