Imports R_Common
Imports SAM01400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "GST0230Service" in code, svc and config file together.
Public Class GST0230Service
    Implements IGST0230Service

    Public Sub sSetPasswordExpired() Implements IGST0230Service.sSetPasswordExpired
        Dim loException As New R_Exception

        Try
            Dim loClass As New GST0230Cls

            loClass.sSetPasswordExpired()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
