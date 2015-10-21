<Serializable()> _
Public Class RGBTrack

    Private _RGBLEDNumber As Integer

    Public Property TotalFrameSlots As Integer

    Public Property TrackID As Guid

    Public Property Frames As List(Of RGBTrackFrame)

    Public Property RGBLEDNumber As Integer
        Get
            Return _RGBLEDNumber
        End Get
        Set(value As Integer)
            _RGBLEDNumber = value
        End Set
    End Property

    Public Sub New(ByVal NewTotalFrameSlots As Integer)
        _Frames = New List(Of RGBTrackFrame)

        For iFrame As Integer = 0 To NewTotalFrameSlots - 1
            AddFrame(New RGBTrackFrame())
        Next

        _TotalFrameSlots = NewTotalFrameSlots

        _TrackID = System.Guid.NewGuid

    End Sub

    Public Sub AddFrame(ByVal NewFrame As RGBTrackFrame)
        NewFrame.ParentTrack = Me
        _Frames.Add(NewFrame)
    End Sub

    Public Sub AdjustTotalFrameSlots(ByVal NewTotalFrameSlots As Integer)
        If _TotalFrameSlots < NewTotalFrameSlots Then
            Dim _NewPositionCount As Integer = NewTotalFrameSlots - _TotalFrameSlots
            _TotalFrameSlots = NewTotalFrameSlots
            For iFrame As Integer = 0 To _NewPositionCount - 1
                AddFrame(New RGBTrackFrame())
            Next
        ElseIf _TotalFrameSlots > NewTotalFrameSlots Then
            Dim _FramesToRemove As Integer = _TotalFrameSlots - NewTotalFrameSlots
            For iFrame As Integer = 0 To _FramesToRemove - 1
                _Frames.RemoveAt(_Frames.Count - 1)
            Next
            _TotalFrameSlots = NewTotalFrameSlots
        End If
    End Sub

    Public Function PositionDisplayName(ByVal FrameToFind As RGBTrackFrame) As String
        Dim _PositionName As String = ""
        Dim _Index As Integer
        _Index = _Frames.FindIndex(Function(x) x.FrameID = FrameToFind.FrameID)

        If _Index > 0 Then
            Dim _Seconds As Integer = 0
            _Seconds = _Index \ 30

            _PositionName = _Seconds & ":" & (_Index Mod 30)
        Else
            _PositionName = "0:0"
        End If

        Return _PositionName
    End Function

    Public Function GetFrameIndex(ByVal FrameToFind As RGBTrackFrame) As String
        Dim _Index As Integer
        _Index = _Frames.FindIndex(Function(x) x.FrameID = FrameToFind.FrameID)
        Return _Index
    End Function
End Class
