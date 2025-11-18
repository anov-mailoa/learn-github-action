' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00050Service" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports ATT00050Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class ATT00050Service
    Implements IATT00050Service


    Public Sub Svc_R_Delete(poEntity As ATT00050Back.ATT00050DTO) Implements R_BackEnd.R_IServicebase(Of ATT00050Back.ATT00050DTO).Svc_R_Delete

        Dim loEx As New R_Exception
        Dim loCls As New ATT00050CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00050Back.ATT00050DTO) As ATT00050Back.ATT00050DTO Implements R_BackEnd.R_IServicebase(Of ATT00050Back.ATT00050DTO).Svc_R_GetRecord

        Dim loEx As New R_Exception
        Dim loCls As New ATT00050CLS
        Dim loRtn As ATT00050DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As ATT00050Back.ATT00050DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00050Back.ATT00050DTO Implements R_BackEnd.R_IServicebase(Of ATT00050Back.ATT00050DTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New ATT00050CLS
        Dim loRtn As ATT00050DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Draft(poParam As ATT00050Back.ATT00050DTO) As ATT00050Back.ATT00050DTO Implements IATT00050Service.Draft
        Dim loEx As New R_Exception
        Dim loRtn As ATT00050DTO = Nothing
        Dim loCls As New ATT00050CLS

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As ATT00050Back.ATT00050DTO) As ATT00050Back.ATT00050DTO Implements IATT00050Service.Submit
        Dim loEx As New R_Exception
        Dim loRtn As ATT00050DTO = Nothing
        Dim loCls As New ATT00050CLS

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
