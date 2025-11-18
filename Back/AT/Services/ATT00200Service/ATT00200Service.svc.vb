Imports R_BackEnd
Imports R_Common
Imports ATT00200Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports ATT00200Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00200Service" in code, svc and config file together.
Public Class ATT00200Service
    Implements IATT00200Service


    Public Sub Svc_R_Delete(poEntity As ATT00200Back.ATT00200DTO) Implements R_BackEnd.R_IServicebase(Of ATT00200Back.ATT00200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00200Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00200Back.ATT00200DTO) As ATT00200Back.ATT00200DTO Implements R_BackEnd.R_IServicebase(Of ATT00200Back.ATT00200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00200Cls
        Dim loRtn As ATT00200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00200Back.ATT00200DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00200Back.ATT00200DTO Implements R_BackEnd.R_IServicebase(Of ATT00200Back.ATT00200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00200Cls
        Dim loRtn As ATT00200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getSchedule(poEntity As ATT00200Back.ATT00200DTO) As ATT00200Back.ATT00200DTO Implements IATT00200Service.getSchedule
        Dim loRtn As New ATT00200DTO
        Dim loCls As New ATT00200Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getSchedule(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftSubmit(poEntity As ATT00200Back.ATT00200DTO) As ATT00200Back.ATT00200DTO Implements IATT00200Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATT00200Cls
        Dim loRtn As New ATT00200DTO

        Try
            loRtn = loCls.DraftSubmit(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
