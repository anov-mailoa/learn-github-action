Imports System.ServiceModel
Imports R_Common
Imports ATT00110Back
Imports ATT00110Common
Imports R_BackEnd

Public Class ATT00110Service
    Implements IATT00110Service
     
    Public Sub Svc_R_Delete(poEntity As ATT00110Back.ATT00110DTO) Implements R_BackEnd.R_IServicebase(Of ATT00110Back.ATT00110DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00110CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00110Back.ATT00110DTO) As ATT00110Back.ATT00110DTO Implements R_BackEnd.R_IServicebase(Of ATT00110Back.ATT00110DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As ATT00110Back.ATT00110DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00110Back.ATT00110DTO Implements R_BackEnd.R_IServicebase(Of ATT00110Back.ATT00110DTO).Svc_R_Save

    End Function

    Public Function DraftSubmit(poCurrent As ATT00110Back.ATT00110DTO) As ATT00110Back.ATT00110DTO Implements IATT00110Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATT00110CLS
        Dim loRtn As New ATT00110DTO

        Try
            loRtn = loCls.DraftSubmit(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
