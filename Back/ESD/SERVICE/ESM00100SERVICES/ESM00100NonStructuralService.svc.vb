Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00100NonStructuralService" in code, svc and config file together.
Public Class ESM00100NonStructuralService
    Implements IESM00100NonStructuralService

    Public Sub Svc_R_Delete(poEntity As ESM00100Back.ESM00100NonStructuralDTO) Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100NonStructuralDTO).Svc_R_Delete
    
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00100Back.ESM00100NonStructuralDTO) As ESM00100Back.ESM00100NonStructuralDTO Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100NonStructuralDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralCls
        Dim loRtn As New ESM00100NonStructuralDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00100Back.ESM00100NonStructuralDTO, poCRUDMode As R_Common.eCRUDMode) As ESM00100Back.ESM00100NonStructuralDTO Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100NonStructuralDTO).Svc_R_Save
  
    End Function

    Public Sub SaveApprovalCode(poParam As ESM00100Back.ESM00100NonStructuralDTO) Implements IESM00100NonStructuralService.SaveApprovalCode
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralCls
        Try
            loCls.SaveApprovalCode(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub DeleteApprovalCode(poParam As ESM00100Back.ESM00100NonStructuralDTO) Implements IESM00100NonStructuralService.DeleteApprovalCode
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100NonStructuralCls
        Try
            loCls.DeleteApprovalCode(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
