Imports R_BackEnd
Imports R_Common
Imports PNM02000Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02000Service" in code, svc and config file together.
Public Class PNM02000Service
    Implements IPNM02000Service

    Public Sub Svc_R_Delete(poEntity As PNM02000Back.PNM02000DTO) Implements R_BackEnd.R_IServicebase(Of PNM02000Back.PNM02000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02000Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02000Back.PNM02000DTO) As PNM02000Back.PNM02000DTO Implements R_BackEnd.R_IServicebase(Of PNM02000Back.PNM02000DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM02000Cls
        Dim loRtn As PNM02000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PNM02000Back.PNM02000DTO, poCRUDMode As R_Common.eCRUDMode) As PNM02000Back.PNM02000DTO Implements R_BackEnd.R_IServicebase(Of PNM02000Back.PNM02000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02000Cls
        Dim loRtn As PNM02000DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getActive(poParam As PNM02000Back.PNM02000DTO) As PNM02000Back.PNM02000DTO Implements IPNM02000Service.getActive
        Dim loEx As New R_Exception
        Dim loCls As New PNM02000Cls
        Dim loRtn As New PNM02000DTO

        Try
            loRtn = loCls.getActive(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
