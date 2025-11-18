Imports R_Common
Imports PYM00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00800PolicyDetailService" in code, svc and config file together.
Public Class PYM00800PolicyDetailService
    Implements IPYM00800PolicyDetailService


    Public Function getSinglePolicyDetail(poParam As PYM00800Back.PYM00800PolicyDetailDTO) As PYM00800Back.PYM00800PolicyDetailDTO Implements IPYM00800PolicyDetailService.getSinglePolicyDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyDetailCls
        Dim loRtn As PYM00800PolicyDetailDTO

        Try
            loRtn = loCls.getSinglePolicyDetail(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
