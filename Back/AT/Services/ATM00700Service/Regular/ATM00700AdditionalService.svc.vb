Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00700Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00700AdditionalService" in code, svc and config file together.
Public Class ATM00700AdditionalService
    Implements IATM00700AdditionalService

    Public Sub Svc_R_Delete(poEntity As ATM00700Back.ATM00700AdditionalDTO) Implements R_BackEnd.R_IServicebase(Of ATM00700Back.ATM00700AdditionalDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00700Back.ATM00700AdditionalDTO) As ATM00700Back.ATM00700AdditionalDTO Implements R_BackEnd.R_IServicebase(Of ATM00700Back.ATM00700AdditionalDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00700AdditionalCls
        Dim loRtn As New ATM00700AdditionalDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00700Back.ATM00700AdditionalDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00700Back.ATM00700AdditionalDTO Implements R_BackEnd.R_IServicebase(Of ATM00700Back.ATM00700AdditionalDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00700AdditionalCls
        Dim loRtn As New ATM00700AdditionalDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getAdditionalLeave(pcCompId As String, pcUserId As String) As System.Collections.Generic.List(Of ATM00700Back.ATM00700AdditionalDTO) Implements IATM00700AdditionalService.getAdditionalLeave
        Dim loEx As New R_Exception
        Dim loCls As New ATM00700AdditionalCls
        Dim loRtn As New List(Of ATM00700AdditionalDTO)

        Try
            loRtn = loCls.getAdditionalLeave(pcCompId, pcUserId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
