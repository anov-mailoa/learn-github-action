Imports System.ServiceModel
Imports R_Common
Imports MCM02000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM02000Service" in code, svc and config file together.
Public Class MCM02000Service
    Implements IMCM02000Service

    Public Sub Svc_R_Delete(poEntity As MCM02000Back.MCM02000DTO) Implements R_BackEnd.R_IServicebase(Of MCM02000Back.MCM02000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCM02000CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCM02000Back.MCM02000DTO) As MCM02000Back.MCM02000DTO Implements R_BackEnd.R_IServicebase(Of MCM02000Back.MCM02000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCM02000CLS
        Dim loRtn As New MCM02000DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCM02000Back.MCM02000DTO, poCRUDMode As R_Common.eCRUDMode) As MCM02000Back.MCM02000DTO Implements R_BackEnd.R_IServicebase(Of MCM02000Back.MCM02000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCM02000CLS
        Dim loRtn As New MCM02000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub saveFullNameParam(poParam As System.Collections.Generic.List(Of MCM02000Back.MCM02000GridDTO)) Implements IMCM02000Service.saveFullNameParam
        Dim loEx As New R_Exception
        Dim loCls As New MCM02000CLS
        Try
            loCls.saveFullNameParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub getCheckSyntax(pcSyntax As String, plFilter As Boolean) Implements IMCM02000Service.getCheckSyntax
        Dim loCls As New MCM02000CLS
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(pcSyntax, plFilter)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
