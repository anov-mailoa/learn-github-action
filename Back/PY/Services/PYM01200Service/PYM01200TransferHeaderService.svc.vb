Imports R_Common
Imports PYM01200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01200TransferHeaderService" in code, svc and config file together.
Public Class PYM01200TransferHeaderService
    Implements IPYM01200TransferHeaderService


    Public Sub Svc_R_Delete(poEntity As PYM01200Back.PYM01200TransferHeaderDTO) Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200TransferHeaderDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01200Back.PYM01200TransferHeaderDTO) As PYM01200Back.PYM01200TransferHeaderDTO Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200TransferHeaderDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls
        Dim loRtn As PYM01200TransferHeaderDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01200Back.PYM01200TransferHeaderDTO, poCRUDMode As R_Common.eCRUDMode) As PYM01200Back.PYM01200TransferHeaderDTO Implements R_BackEnd.R_IServicebase(Of PYM01200Back.PYM01200TransferHeaderDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls
        Dim loRtn As PYM01200TransferHeaderDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGsmCashBank(poParam As PYM01200Back.PYM01200BankAccountDTO) As Boolean Implements IPYM01200TransferHeaderService.getGsmCashBank
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getGsmCashBank(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGsmCurrency(poParam As PYM01200Back.PYM01200BankAccountDTO) As Boolean Implements IPYM01200TransferHeaderService.getGsmCurrency
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getGsmCurrency(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
