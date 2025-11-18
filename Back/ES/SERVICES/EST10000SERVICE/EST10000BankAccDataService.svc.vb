Imports R_Common
Imports EST10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000BankAccDataService" in code, svc and config file together.
Public Class EST10000BankAccDataService
    Implements IEST10000BankAccDataService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000BankAccDataDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000BankAccDataDTO).Svc_R_Delete

    End Sub


    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000BankAccDataDTO) As EST10000Back.EST10000BankAccDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000BankAccDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000BankAccDataCls
        Dim loRtn As New EST10000BankAccDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000BankAccDataDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000BankAccDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000BankAccDataDTO).Svc_R_Save

    End Function

    Public Sub ApprovalBankAccountData(poParam As EST10000Back.EST10000BankAccDataDTO) Implements IEST10000BankAccDataService.ApprovalBankAccountData
        Dim loEx As New R_Exception
        Dim loCls As New EST10000BankAccDataCls
        Try
            loCls.ApprovalBankAccountData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
