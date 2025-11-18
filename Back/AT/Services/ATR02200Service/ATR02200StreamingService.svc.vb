Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR02200Back
Imports ATR02200Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR02200StreamingService" in code, svc and config file together.
Public Class ATR02200StreamingService
    Implements IATR02200StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR02200StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR02200CLS
        Dim poParam As New ATR02200DTO
        Dim loRtnList As New List(Of ATR02200ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cAllWorkgroup = R_Utility.R_GetStreamingContext("cAllWorkgroup")
                .cWorkgroupList = R_Utility.R_GetStreamingContext("cWorkgroupList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReport(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR02200ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLegend() As System.ServiceModel.Channels.Message Implements IATR02200StreamingService.getLegend
        Dim loException As New R_Exception
        Dim loCls As New ATR02200CLS
        Dim poParam As New ATR02200DTO
        Dim loRtnList As New List(Of ATR02200ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getLegend(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR02200ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLegend")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
