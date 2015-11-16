Public Class FASTDriver

    Public Property ID As String

    Private _RawConfigLine As String

    Public Property Trigger As String
    Public Property SwitchId As String
    Public Property Mode As String
    Public Property Param1 As String
    Public Property Param2 As String
    Public Property Param3 As String
    Public Property Param4 As String
    Public Property Param5 As String

    Public Property RawConfigLine As String
        Get
            Return _RawConfigLine
        End Get
        Set(value As String)
            _RawConfigLine = value
            Dim _Parts() As String = _RawConfigLine.Split({" "}, StringSplitOptions.RemoveEmptyEntries)

            _ID = _Parts(0)
            _Trigger = _Parts(1)
            _SwitchId = _Parts(2)
            _Mode = _Parts(3)
            _Param1 = _Parts(4)
            _Param2 = _Parts(5)
            _Param3 = _Parts(6)
            _Param4 = _Parts(7)
            _Param5 = _Parts(8)
        End Set
    End Property

End Class
