Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00540Back
Imports ATR00540Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00540StreamingService" in code, svc and config file together.
Public Class ATR00540StreamingService
    Implements IATR00540StreamingService

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IATR00540StreamingService.getReport
        Dim loException As New R_Exception
        Dim loCls As New ATR00540CLS
        Dim poParam As New ATR00540DTO
        Dim loRtnList As List(Of ATR00540ReportDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cStartDate = R_Utility.R_GetStreamingContext("cStartDate")
                .cEndDate = R_Utility.R_GetStreamingContext("cEndDate")
                .cFilterBy = R_Utility.R_GetStreamingContext("cFilterBy")
                .lAllEmp = R_Utility.R_GetStreamingContext("lAllEmp")
                .cEmpList = R_Utility.R_GetStreamingContext("cEmpList")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With

            loRtnList = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR00540ReportDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
