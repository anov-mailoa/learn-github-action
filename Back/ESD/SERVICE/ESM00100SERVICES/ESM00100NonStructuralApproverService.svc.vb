Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00100NonStructuralApproverService" in code, svc and config file together.
Public Class ESM00100NonStructuralApproverService
    Implements IESM00100NonStructuralApproverService

    Public Sub Svc_R_Delete(poEntity As ESM00100Back.ESM00100NonStructuralApproverDTO) Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100NonStructuralApproverDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralApproverCls

        Try

            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00100Back.ESM00100NonStructuralApproverDTO) As ESM00100Back.ESM00100NonStructuralApproverDTO Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100NonStructuralApproverDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralApproverCls
        Dim loRtn As New ESM00100NonStructuralApproverDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00100Back.ESM00100NonStructuralApproverDTO, poCRUDMode As R_Common.eCRUDMode) As ESM00100Back.ESM00100NonStructuralApproverDTO Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100NonStructuralApproverDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralApproverCls
        Dim loRtn As New ESM00100NonStructuralApproverDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub SavePositionSequence(poParam As System.Collections.Generic.List(Of ESM00100Back.ESM00100NonStructuralApproverDTO)) Implements IESM00100NonStructuralApproverService.SavePositionSequence
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralApproverCls
        Try
            loCls.SavePositionSequence(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
