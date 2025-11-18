Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR03100Back
Imports ATR03100Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR03100StreamingService" in code, svc and config file together.
Public Class ATR03100StreamingService
    Implements IATR03100StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR03100StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR03100CLS
        Dim poParam As New ATR03100DTO
        Dim loRtnList As New List(Of ATR03100ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPeriod = R_Utility.R_GetStreamingContext("cPeriod")
                .cFilterBy = R_Utility.R_GetStreamingContext("cFilterBy")
                .cAllEmployee = R_Utility.R_GetStreamingContext("cAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getReport(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR03100ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLegend() As System.ServiceModel.Channels.Message Implements IATR03100StreamingService.getLegend
        Dim loException As New R_Exception
        Dim loCls As New ATR03100CLS
        Dim poParam As New ATR03100DTO
        Dim loRtnList As New List(Of ATR03100ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getLegend(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR03100ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLegend")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
