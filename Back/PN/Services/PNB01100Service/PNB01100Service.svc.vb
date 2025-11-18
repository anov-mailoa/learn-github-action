Imports R_Common
Imports PNB01100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNB01100Service" in code, svc and config file together.
Public Class PNB01100Service
    Implements IPNB01100Service

    Public Function GetEmployee(poParam As PNB01100Back.PNB01100DTO) As PNB01100Back.PNB01100DTO Implements IPNB01100Service.GetEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PNB01100Cls
        Dim loRtn As New PNB01100DTO

        Try
            loRtn = loCls.GetEmployee(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
