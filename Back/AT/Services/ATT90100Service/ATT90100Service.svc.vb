Imports R_BackEnd
Imports R_Common
Imports ATT90100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90100Service" in code, svc and config file together.
Public Class ATT90100Service
    Implements IATT90100Service

    Public Sub Svc_R_Delete(poEntity As ATT90100Back.ATT90100Dto) Implements R_BackEnd.R_IServicebase(Of ATT90100Back.ATT90100Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT90100CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90100Back.ATT90100Dto) As ATT90100Back.ATT90100Dto Implements R_BackEnd.R_IServicebase(Of ATT90100Back.ATT90100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtn As New ATT90100Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT90100Back.ATT90100Dto, poCRUDMode As R_Common.eCRUDMode) As ATT90100Back.ATT90100Dto Implements R_BackEnd.R_IServicebase(Of ATT90100Back.ATT90100Dto).Svc_R_Save

    End Function

    Public Function GetTransactionProfile(poParam As ATT90100Back.ATT90100Dto) As ATT90100Back.ATT90100Dto Implements IATT90100Service.GetTransactionProfile
        Dim loEx As New R_Exception
        Dim loCls As New ATT90100CLS
        Dim loRtn As New ATT90100Dto

        Try
            loRtn = loCls.GetTransactionProfile(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub SubmitOrDraft(poParam As ATT90100Back.ATT90100Dto) Implements IATT90100Service.SubmitOrDraft
        Dim loEx As New R_Exception
        Dim loCls As New ATT90100CLS

        Try
            loCls.SubmitOrDraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
