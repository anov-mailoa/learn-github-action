Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00500TransactionService" in code, svc and config file together.
Public Class ATT00500TransactionService
    Implements IATT00500TransactionService

    'Public Sub DoWork() Implements IATT00500TransactionService.DoWork
    'End Sub

    'Public Sub Svc_R_Delete(poEntity As ATT00500Back.ATT00500TransactionDTO) Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500EntryDTO).Svc_R_Delete
    '    Dim loEx As New R_Exception
    '    Dim loCls As New ATT00500TransactionCLS
    '    Dim loRtn As ATT00500EntryDTO
    '    Try
    '        loCls.R_Delete(poEntity)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    'Public Function Svc_R_GetRecord(poEntity As ATT00500Back.ATT00500TransactionDTO) As ATT00500Back.ATT00500EntryDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500EntryDTO).Svc_R_GetRecord
    '    Dim loEx As New R_Exception
    '    Dim loCls As New ATT00500TransactionCLS
    '    Dim loRtn As ATT00500EntryDTO
    '    Try
    '        loRtn = loCls.R_GetRecord(poEntity)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn
    'End Function

    'Public Function Svc_R_Save(poEntity As ATT00500Back.ATT00500EntryDTO, poCRUDMode As R_Common.eCRUDMode) As ATT00500Back.ATT00500EntryDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500EntryDTO).Svc_R_Save
    '    Dim loEx As New R_Exception
    '    Dim loCls As New ATT00500TransactionCLS
    '    Dim loRtn As ATT00500EntryDTO
    '    Try
    '        loRtn = loCls.R_Save(poEntity, poCRUDMode)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn
    'End Function

    'Public Function getATMShift(poParam As ATT00500Back.ATT00500EntryDTO) As ATT00500Back.ATT00500EntryDTO Implements IATT00500TransactionService.getATMShift
    '    Dim loCls As New ATT00500TransactionCLS
    '    Dim loEx As New R_Exception
    '    Dim loRtn As ATT00500EntryDTO
    '    Try
    '        Dim poParams As New ATT00500EntryDTO
    '        poParams.cCompanyId = poParam.cCompanyId.Trim
    '        poParams.cShiftCode = poParam.cCompanyId.Trim
    '        loRtn = loCls.getATMShift(poParams)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn

    'End Function

    Public Sub Svc_R_Delete(poEntity As ATT00500Back.ATT00500TransactionDTO) Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500TransactionDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500TransactionCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00500Back.ATT00500TransactionDTO) As ATT00500Back.ATT00500TransactionDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500TransactionDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500TransactionCLS
        Dim loRtn As ATT00500TransactionDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00500Back.ATT00500TransactionDTO, poCRUDMode As R_Common.eCRUDMode) As ATT00500Back.ATT00500TransactionDTO Implements R_BackEnd.R_IServicebase(Of ATT00500Back.ATT00500TransactionDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500TransactionCLS
        Dim loRtn As ATT00500TransactionDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub DoWork() Implements IATT00500TransactionService.DoWork

    End Sub

    Public Function GetTransactionProfileRtn(poParam As ATT00500Back.ATT00500TransactionDTO) As ATT00500Back.ATT00500TransactionDTO Implements IATT00500TransactionService.GetTransactionProfileRtn
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500TransactionCLS
        Dim loRtn As ATT00500TransactionDTO
        Try
            loRtn = loCls.GetTransactionProfileRtn(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    Public Function changeDraftUndraft(poParam As ATT00500Back.ATT00500TransactionDTO) As ATT00500Back.ATT00500TransactionDTO Implements IATT00500TransactionService.changeDraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500TransactionCLS
        Dim loRtn As ATT00500TransactionDTO
        Try
            loRtn = loCls.changeDraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftProcess(poParam As ATT00500Back.ATT00500TransactionDTO) As ATT00500Back.ATT00500TransactionDTO Implements IATT00500TransactionService.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500TransactionCLS
        Dim loRtn As New ATT00500TransactionDTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As ATT00500Back.ATT00500TransactionDTO) As ATT00500Back.ATT00500TransactionDTO Implements IATT00500TransactionService.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New ATT00500TransactionCLS
        Dim loRtn As New ATT00500TransactionDTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
