Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB02000Back

Public Class MCB02000GenerateTransferFileService
    Implements IMCB02000GenerateTransferFileService

    Public Function getCurrentMedicalYear(ByVal poParam As MCB02000Back.MCB02000TransferBankDocumentDto) As MCB02000Back.MCB02000TransferBankDocumentDto Implements IMCB02000GenerateTransferFileService.getCurrentMedicalYear
        Dim loException As New R_Exception
        Dim loCls As New MCB02000GenerateTransferFileCls
        Dim loRtn As New MCB02000TransferBankDocumentDto

        Try
            loRtn = loCls.getCurrentMedicalYear(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Svc_R_Delete(ByVal poEntity As MCB02000Back.MCB02000TransferBankDocumentDto) Implements R_BackEnd.R_IServicebase(Of MCB02000Back.MCB02000TransferBankDocumentDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As MCB02000Back.MCB02000TransferBankDocumentDto) As MCB02000Back.MCB02000TransferBankDocumentDto Implements R_BackEnd.R_IServicebase(Of MCB02000Back.MCB02000TransferBankDocumentDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As MCB02000Back.MCB02000TransferBankDocumentDto, ByVal poCRUDMode As R_Common.eCRUDMode) As MCB02000Back.MCB02000TransferBankDocumentDto Implements R_BackEnd.R_IServicebase(Of MCB02000Back.MCB02000TransferBankDocumentDto).Svc_R_Save

    End Function

    Public Function getInit(poParam As String) As Boolean Implements IMCB02000GenerateTransferFileService.getInit
        Dim loException As New R_Exception
        Dim loCls As New MCB02000GenerateTransferFileCls
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
