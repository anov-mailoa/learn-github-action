Imports System.ServiceModel
Imports R_Common
Imports PNM09000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM09000Service" in code, svc and config file together.
Public Class PNM09000Service
    Implements IPNM09000Service

    Public Sub Svc_R_Delete(poEntity As PNM09000Back.PNM09000DTO) Implements R_BackEnd.R_IServicebase(Of PNM09000Back.PNM09000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM09000Back.PNM09000DTO) As PNM09000Back.PNM09000DTO Implements R_BackEnd.R_IServicebase(Of PNM09000Back.PNM09000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtn As PNM09000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM09000Back.PNM09000DTO, poCRUDMode As R_Common.eCRUDMode) As PNM09000Back.PNM09000DTO Implements R_BackEnd.R_IServicebase(Of PNM09000Back.PNM09000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtn As PNM09000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function


    Public Function CheckUser(poParam As PNM09000Back.PNM09000DTO) As Boolean Implements IPNM09000Service.CheckUser
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckUser(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAlertDays(poParam As PNM09000Back.PNM09000DTO) As PNM09000Back.PNM09000DTO Implements IPNM09000Service.getAlertDays
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtn As PNM09000DTO

        Try
            loRtn = loCls.getAlertDays(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SaveAlertDays(poParam As PNM09000Back.PNM09000DTO) As PNM09000Back.PNM09000DTO Implements IPNM09000Service.SaveAlertDays
        Dim loEx As New R_Exception
        Dim loCls As New PNM09000Cls
        Dim loRtn As New PNM09000DTO

        Try
            loRtn = loCls.SaveAlertDays(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
