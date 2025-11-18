Imports R_Common
Imports PNB01200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNB01200Service" in code, svc and config file together.
Public Class PNB01200Service
    Implements IPNB01200Service

    Public Function GetEmployee(poParam As PNB01200Back.PNB01200DTO) As PNB01200Back.PNB01200DTO Implements IPNB01200Service.GetEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PNB01200Cls
        Dim loRtn As New PNB01200DTO

        Try
            loRtn = loCls.GetEmployee(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
