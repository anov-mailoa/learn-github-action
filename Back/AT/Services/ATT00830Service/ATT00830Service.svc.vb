Imports System.ServiceModel
Imports R_Common
Imports ATT00830Back
Imports ATT00830Common
Imports R_BackEnd

Public Class ATT00830Service
    Implements IATT00830Service
     
    Public Sub Svc_R_Delete(poEntity As ATT00830Back.ATT00830DTO) Implements R_BackEnd.R_IServicebase(Of ATT00830Back.ATT00830DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00830CLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00830Back.ATT00830DTO) As ATT00830Back.ATT00830DTO Implements R_BackEnd.R_IServicebase(Of ATT00830Back.ATT00830DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00830CLS
        Dim loRtn As New ATT00830DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00830Back.ATT00830DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00830Back.ATT00830DTO Implements R_BackEnd.R_IServicebase(Of ATT00830Back.ATT00830DTO).Svc_R_Save

    End Function

    Public Function DraftSubmit(poCurrent As ATT00830Back.ATT00830DTO) As ATT00830Back.ATT00830DTO Implements IATT00830Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATT00830CLS
        Dim loRtn As New ATT00830DTO

        Try
            loRtn = loCls.DraftSubmit(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
