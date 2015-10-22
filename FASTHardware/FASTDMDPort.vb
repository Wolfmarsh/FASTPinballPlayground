Imports FASTHardware

Public Class FASTDMDPort
    Inherits FASTPort

    Public Overrides ReadOnly Property PortType As eFASTPortType
        Get
            Return eFASTPortType.DMD
        End Get
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
End Class
