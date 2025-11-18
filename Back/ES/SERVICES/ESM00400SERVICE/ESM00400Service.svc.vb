Imports System.ServiceModel
Imports R_Common
Imports ESM00400Back
Imports R_BackEnd
Imports SIAPP_SERVICE_ES

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00400Service" in code, svc and config file together.
Public Class ESM00400Service
    Implements IESM00400Service

    Public Sub Svc_R_Delete(poEntity As ESM00400Back.ESM00400DTO) Implements R_BackEnd.R_IServicebase(Of ESM00400Back.ESM00400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00400Back.ESM00400DTO) As ESM00400Back.ESM00400DTO Implements R_BackEnd.R_IServicebase(Of ESM00400Back.ESM00400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS
        Dim loRtn As ESM00400DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00400Back.ESM00400DTO, poCRUDMode As R_Common.eCRUDMode) As ESM00400Back.ESM00400DTO Implements R_BackEnd.R_IServicebase(Of ESM00400Back.ESM00400DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS
        Dim loRtn As ESM00400DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getESSMembershipStatus(pcCompId As String) As ESM00400Back.ESM00400DTO Implements IESM00400Service.getESSMembershipStatus
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS
        Dim loRtn As New ESM00400DTO
        Try
            loRtn = loCls.getESSMembershipStatus(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub deleteEmpAttLocation(poParam As ESM00400Back.ESM00400DTO) Implements IESM00400Service.deleteEmpAttLocation
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS

        Try
            loCls.deleteEmpAttLocation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub resetUserApproval(poParam As ESM00400DTO) Implements IESM00400Service.resetUserApproval
        'FK 06/05/2025'
        Dim loEx As New R_Exception
        Dim loCls As New ESM00400CLS

        Try
            loCls.updateUserApproval(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
