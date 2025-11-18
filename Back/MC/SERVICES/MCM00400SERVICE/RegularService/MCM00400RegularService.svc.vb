Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM00400Back

Public Class MCM00400RegularService
    Implements IMCM00400RegularService

    Public Sub Svc_R_Delete(poEntity As MCM00400Back.MCM00400GridDto) Implements R_BackEnd.R_IServicebase(Of MCM00400Back.MCM00400GridDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM00400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM00400Back.MCM00400GridDto) As MCM00400Back.MCM00400GridDto Implements R_BackEnd.R_IServicebase(Of MCM00400Back.MCM00400GridDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM00400Cls
        Dim loRtn As New MCM00400GridDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM00400Back.MCM00400GridDto, poCRUDMode As R_Common.eCRUDMode) As MCM00400Back.MCM00400GridDto Implements R_BackEnd.R_IServicebase(Of MCM00400Back.MCM00400GridDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCLS As New MCM00400Cls
        Dim loRtn As New MCM00400GridDto

        Try
            loRtn = loCLS.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
