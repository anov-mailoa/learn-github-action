Imports R_Common
Imports MCM00500Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00500DetailService" in code, svc and config file together.
Public Class MCM00500DetailService
    Implements IMCM00500DetailService

    Public Sub Svc_R_Delete(poEntity As MCM00500Back.MCM00500DetailDTO) Implements R_BackEnd.R_IServicebase(Of MCM00500Back.MCM00500DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00500Cls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00500Back.MCM00500DetailDTO) As MCM00500Back.MCM00500DetailDTO Implements R_BackEnd.R_IServicebase(Of MCM00500Back.MCM00500DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM00500Cls
        Dim loRtn As New MCM00500DetailDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00500Back.MCM00500DetailDTO, poCRUDMode As R_Common.eCRUDMode) As MCM00500Back.MCM00500DetailDTO Implements R_BackEnd.R_IServicebase(Of MCM00500Back.MCM00500DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM00500Cls
        Dim loRtn As New MCM00500DetailDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of MCM00500Back.MCM00500DetailGridDTO)) Implements IMCM00500DetailService.Dummy

    End Sub

    Public Sub removeAll(poParam As MCM00500Back.MCM00500DetailDTO) Implements IMCM00500DetailService.removeAll
        Dim loEx As New R_Exception
        Dim loCls As New MCM00500Cls
        Try
            loCls.removeAll(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
