Imports System.IO
Imports System.Xml.Serialization

<Serializable()> _
Public Class RGBAnimationProject
    Public Event TracksChanged()
    Public Event FrameSelected(sender As Object)

    Public Property Filename As String
    Public Property Filepath As String
    Public Property Tracks As List(Of RGBTrack)

    Public Property TotalFrameSlots As Integer

    Public Sub New()
        Me.New(30)
    End Sub

    Public Sub New(ByVal TotalFrameSlots As Integer)
        _TotalFrameSlots = TotalFrameSlots
        _Tracks = New List(Of RGBTrack)
        _Filename = "Untitled.fastrgb"
    End Sub

    Public Sub Save()
        If String.IsNullOrEmpty(Filename) Or String.IsNullOrEmpty(Filepath) Then
            'Dim _SaveFileDialog As New SaveFileDialog
            '_SaveFileDialog.FileName = _Filename
            '_SaveFileDialog.ShowDialog()
            '_SaveFileDialog.Filter = "All files (*.*)|*.*"
            '_SaveFileDialog.RestoreDirectory = True
            'Dim _TempFilename = _SaveFileDialog.FileName
            'If String.IsNullOrEmpty(_TempFilename) Then Exit Sub
            '_Filename = System.IO.Path.GetFileName(_TempFilename)
            '_Filepath = _TempFilename.Replace(_Filename, "")
        End If

        Dim extraTypes(5) As Type
        extraTypes(0) = GetType(RGBTrack)
        extraTypes(1) = GetType(RGBTrackFrame)

        Dim _StreamWriter As New StreamWriter(_Filepath & _Filename)
        Dim _Serializer As New XmlSerializer(GetType(RGBAnimationProject), extraTypes)
        _Serializer.Serialize(_StreamWriter, Me)
        _StreamWriter.Close()
    End Sub

    Public Sub AddTrack(ByVal NewTrack As RGBTrack)
        _Tracks.Add(NewTrack)
        RaiseEvent TracksChanged()
    End Sub

    Public Sub AdjustTotalFrameSlots(ByVal NewTotalFrameSlots As Integer)
        For Each _Track As RGBTrack In _Tracks
            _Track.AdjustTotalFrameSlots(NewTotalFrameSlots)
        Next
        TotalFrameSlots = NewTotalFrameSlots
        RaiseEvent TracksChanged()
    End Sub

    Public Function GetNextTrackLEDNumber() As Integer
        Dim _NewLEDNumber As Integer = 0
        Dim _LEDNumberUsed As Boolean = False

        If _Tracks.Find(Function(x) x.RGBLEDNumber = _NewLEDNumber) IsNot Nothing Then
            _LEDNumberUsed = True
        End If

        While _LEDNumberUsed = True
            _NewLEDNumber += 1
            If _Tracks.Find(Function(x) x.RGBLEDNumber = _NewLEDNumber) IsNot Nothing Then
                _LEDNumberUsed = True
            Else
                _LEDNumberUsed = False
            End If
        End While
        Return _NewLEDNumber
    End Function

    Public Function HasTrackWithLEDNumber(ByVal LEDNumber As Integer) As Boolean
        If _Tracks.Find(Function(x) x.RGBLEDNumber = LEDNumber) IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
