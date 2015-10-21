Public Class FASTSwitch

    Public Event SwitchStateChanged(ByVal sender As System.Object, ByVal e As FASTSwitchStateChangedArgs)

    Public Property DisplayName As String

    Private _Closed As Boolean
    Public Property Closed As Boolean
        Get
            Return _Closed
        End Get
        Set(value As Boolean)
            _Closed = value
            RaiseEvent SwitchStateChanged(Me, New FASTSwitchStateChangedArgs())
        End Set
    End Property

    Public Sub New(ByVal Name As String)
        DisplayName = Name
    End Sub
End Class
