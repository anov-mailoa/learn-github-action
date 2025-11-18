Imports R_Common

Public Class SIAPP_SERVICE_PYLogCLS
    Private Shared loLogger As R_LoggerBase

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property Log() As R_LoggerBase
        Get
            Return loLogger
        End Get
    End Property

    Shared Sub New()
        loLogger = New R_LoggerBase(GetType(SIAPP_SERVICE_PYLogCLS))
    End Sub
End Class
