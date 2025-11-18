Imports System.ServiceModel
Imports R_Common
Imports ATM00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00610SPQService" in code, svc and config file together.
Public Class ATM00610PatternSeqService
    Implements IATM00610PatternSeqService

    Public Sub Svc_R_Delete(poEntity As ATM00600Back.ATM00610PatternSeqDTO) Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00610PatternSeqDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00610PatternSeqCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00600Back.ATM00610PatternSeqDTO) As ATM00600Back.ATM00610PatternSeqDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00610PatternSeqDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00610PatternSeqCLS
        Dim loRtn As ATM00610PatternSeqDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00600Back.ATM00610PatternSeqDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00600Back.ATM00610PatternSeqDTO Implements R_BackEnd.R_IServicebase(Of ATM00600Back.ATM00610PatternSeqDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00610PatternSeqCLS
        Dim loRtn As ATM00610PatternSeqDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
