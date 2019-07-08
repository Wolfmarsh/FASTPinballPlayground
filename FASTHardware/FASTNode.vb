Public Class FASTNode
    Public Enum eFASTNodeType
        Unknown = 0
        IO1616
    End Enum

    Private _RawConfigLine As String
    Private _Node As String
    Private _NodeName As String
    Private _Version As String
    Private _SW As String
    Private _DR As String
    Private _XI As String
    Private _XO As String
    Private _SerialNumber As String

    Public Property RawConfigLine As String
        Get
            Return _RawConfigLine
        End Get
        Set(value As String)
            _RawConfigLine = value
            Dim _Parts() As String = _RawConfigLine.Split({" "}, StringSplitOptions.RemoveEmptyEntries)
            _Node = _Parts(0)
            _NodeName = _Parts(1)
            _Version = _Parts(2)
            Try
                _SW = Convert.ToInt32(_Parts(3), 16)
            Catch ex As Exception
                _SW = _Parts(3)
            End Try
            Try
                _DR = Convert.ToInt32(_Parts(4), 16)
            Catch ex As Exception
                _DR = _Parts(4)
            End Try
            _XI = _Parts(5)
            _XO = _Parts(6)
            _SerialNumber = _Parts(7)
        End Set
    End Property

    Public ReadOnly Property Node As String
        Get
            Return _Node
        End Get
    End Property

    Public ReadOnly Property NodeName As String
        Get
            Return _NodeName
        End Get
    End Property

    Public ReadOnly Property Version As String
        Get
            Return _Version
        End Get
    End Property

    Public ReadOnly Property SW As String
        Get
            Return _SW
        End Get
    End Property

    Public ReadOnly Property DR As String
        Get
            Return _DR
        End Get
    End Property

    Public ReadOnly Property XI As String
        Get
            Return _XI
        End Get
    End Property

    Public ReadOnly Property XO As String
        Get
            Return _XO
        End Get
    End Property

    Public ReadOnly Property SerialNumber As String
        Get
            Return _SerialNumber
        End Get
    End Property

End Class
