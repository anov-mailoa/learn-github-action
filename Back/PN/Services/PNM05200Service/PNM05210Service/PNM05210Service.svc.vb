Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM05210Service" in code, svc and config file together.
Public Class PNM05210Service
    Implements IPNM05210Service

    Public Sub Svc_R_Delete(poEntity As PNM05200Back.PNM05210DTO) Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05210DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM05200Back.PNM05210DTO) As PNM05200Back.PNM05210DTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05210DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM05210Cls
        Dim loRtn As PNM05210DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM05200Back.PNM05210DTO, poCRUDMode As R_Common.eCRUDMode) As PNM05200Back.PNM05210DTO Implements R_BackEnd.R_IServicebase(Of PNM05200Back.PNM05210DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM05210Cls
        Dim loRtn As PNM05210DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getChangePersonalData(poEntity As PNM05200Back.PNM05210DTO) As Boolean Implements IPNM05210Service.getChangePersonalData
        Dim loEx As New R_Exception
        Dim loCls As New PNM05210Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getChangePersonalData(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getBlacklistNote(poEntity As PNM05200Back.PNM05210DTO) As String Implements IPNM05210Service.getBlacklistNote
        Dim loEx As New R_Exception
        Dim loCls As New PNM05210Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getBlacklistNotes(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getProbationNotes(poEntity As PNM05200Back.PNM05210DTO) As String Implements IPNM05210Service.getProbationNotes
        Dim loEx As New R_Exception
        Dim loCls As New PNM05210Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getProbationNotes(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
