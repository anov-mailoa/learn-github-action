Imports R_BackEnd
Imports R_Common
Imports ATT90800Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90800Service" in code, svc and config file together.
Public Class ATT90800Service
    Implements IATT90800Service

    Public Sub Svc_R_Delete(poEntity As ATT90800Back.ATT90800Dto) Implements R_BackEnd.R_IServicebase(Of ATT90800Back.ATT90800Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT90800CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90800Back.ATT90800Dto) As ATT90800Back.ATT90800Dto Implements R_BackEnd.R_IServicebase(Of ATT90800Back.ATT90800Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT90800CLS
        Dim loRtn As New ATT90800Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT90800Back.ATT90800Dto, poCRUDMode As R_Common.eCRUDMode) As ATT90800Back.ATT90800Dto Implements R_BackEnd.R_IServicebase(Of ATT90800Back.ATT90800Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT90800CLS
        Dim loRtn As New ATT90800Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetTransactionProfile(poParam As ATT90800Back.ATT90800Dto) As ATT90800Back.ATT90800Dto Implements IATT90800Service.GetTransactionProfile
        Dim loEx As New R_Exception
        Dim loCls As New ATT90800CLS
        Dim loRtn As New ATT90800Dto

        Try
            loRtn = loCls.GetTransactionProfile(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub SubmitOrDraft(poParam As ATT90800Back.ATT90800Dto) Implements IATT90800Service.SubmitOrDraft
        Dim loEx As New R_Exception
        Dim loCls As New ATT90800CLS

        Try
            loCls.SubmitOrDraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
