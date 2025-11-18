Imports R_BackEnd
Imports R_Common
Imports ATT00100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports ATT00100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00100Service" in code, svc and config file together.
Public Class ATT00100Service
    Implements IATT00100Service
     
    Public Sub Svc_R_Delete(poEntity As ATT00100Back.ATT00100DTO) Implements R_BackEnd.R_IServicebase(Of ATT00100Back.ATT00100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00100Back.ATT00100DTO) As ATT00100Back.ATT00100DTO Implements R_BackEnd.R_IServicebase(Of ATT00100Back.ATT00100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls
        Dim loRtn As New ATT00100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00100Back.ATT00100DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00100Back.ATT00100DTO Implements R_BackEnd.R_IServicebase(Of ATT00100Back.ATT00100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls
        Dim loRtn As ATT00100DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftSubmit(poEntity As ATT00100Back.ATT00100DTO) As ATT00100Back.ATT00100DTO Implements IATT00100Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls
        Dim loRtn As New ATT00100DTO

        Try
            loRtn = loCls.DraftSubmit(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getSystemParam(pcCompId As String) As ATT00100DTO Implements IATT00100Service.getSystemParam
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls
        Dim loRtn As New ATT00100DTO

        Try
            loRtn = loCls.getSystemParam(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckShift(poParam As ATT00100Back.ATT00100DTO) As Boolean Implements IATT00100Service.CheckShift
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckShift(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getScheduleDate(poParam As ATT00100Back.ATT00100DTO) As ATT00100DTO Implements IATT00100Service.getScheduleDate
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls
        Dim loRtn As New ATT00100DTO

        Try
            loRtn = loCls.getScheduleDate(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getHoliday(poParam As ATT00100Back.ATT00100DTO) As ATT00100Back.ATT00100DTO Implements IATT00100Service.getHoliday
        Dim loEx As New R_Exception
        Dim loCls As New ATT00100Cls
        Dim loRtn As New ATT00100DTO

        Try
            loRtn = loCls.getHoliday(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

End Class
