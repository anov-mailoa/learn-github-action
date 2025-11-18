Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB02100Back

Public Class MCB02100GenerateTransferFileService
    Implements IMCB02100GenerateTransferFileService

    Public Sub Svc_R_Delete(poEntity As MCB02100Back.MCB02100TransferBankDocumentDto) Implements R_BackEnd.R_IServicebase(Of MCB02100Back.MCB02100TransferBankDocumentDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCB02100Back.MCB02100TransferBankDocumentDto) As MCB02100Back.MCB02100TransferBankDocumentDto Implements R_BackEnd.R_IServicebase(Of MCB02100Back.MCB02100TransferBankDocumentDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCB02100Back.MCB02100TransferBankDocumentDto, poCRUDMode As R_Common.eCRUDMode) As MCB02100Back.MCB02100TransferBankDocumentDto Implements R_BackEnd.R_IServicebase(Of MCB02100Back.MCB02100TransferBankDocumentDto).Svc_R_Save

    End Function

    Public Function getCurrentMedicalYear(poParam As MCB02100Back.MCB02100TransferBankDocumentDto) As MCB02100Back.MCB02100TransferBankDocumentDto Implements IMCB02100GenerateTransferFileService.getCurrentMedicalYear
        Dim loException As New R_Exception
        Dim loCls As New MCB02100GenerateTransferFileCls
        Dim loRtn As New MCB02100TransferBankDocumentDto

        Try
            loRtn = loCls.getCurrentMedicalYear(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getInit(poParam As String) As Boolean Implements IMCB02100GenerateTransferFileService.getInit
        Dim loException As New R_Exception
        Dim loCls As New MCB02100GenerateTransferFileCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getInit(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
