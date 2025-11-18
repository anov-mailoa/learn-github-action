Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00700Back
Imports ATR00700Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00700StreamingService" in code, svc and config file together.
Public Class ATR00700StreamingService
    Implements IATR00700StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR00700StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR00700Cls
        Dim poParam As New ATR00700DTO
        Dim loRtnList As New List(Of ATR00700ReportDTO)
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
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnList = loCls.getReport(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00700ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getLegend() As System.ServiceModel.Channels.Message Implements IATR00700StreamingService.getLegend
        Dim loException As New R_Exception
        Dim loCls As New ATR00700Cls
        Dim poParam As New ATR00700DTO
        Dim loRtnList As New List(Of ATR00700ReportDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getLegend(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00700ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getLegend")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
