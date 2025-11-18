Imports R_BackEnd
Imports R_Common
Imports PNM02000Back
Imports PNM02000Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02000StreamingService" in code, svc and config file together.
Public Class PNM02000StreamingService
    Implements IPNM02000StreamingService

    Public Function getLocation() As System.ServiceModel.Channels.Message Implements IPNM02000StreamingService.getLocation
        Dim loException As New R_Exception
        Dim loCls As New PNM02000Cls
        Dim loRtnTemp As List(Of PNM02000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02000DTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")

            loRtnTemp = loCls.getLocation(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "LocationData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNM02000StreamingService.getReport
        Dim loCls As New PNM02000Cls
        Dim loRtnTemp As List(Of PNM02000ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02000DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02000ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParamPNM00400Grid As System.Collections.Generic.List(Of PNM02000Back.PNM02000GridDTO)) Implements IPNM02000StreamingService.Dummy

    End Sub
End Class
