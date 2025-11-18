Imports System.ServiceModel
Imports R_Common
Imports PYM10000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYM10000Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM10000StreamingService" in code, svc and config file together.
Public Class PYM10000StreamingService
    Implements IPYM10000StreamingService

    Public Function getCustomReportCellList() As System.ServiceModel.Channels.Message Implements IPYM10000StreamingService.getCustomReportCellList
        Dim loEx As New R_Exception
        Dim loCls As New PYM10000Cls
        Dim loRtn As New List(Of PYM10000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM10000DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cReportId = R_Utility.R_GetStreamingContext("cReportId")
            End With

            loRtn = loCls.getCustomReportCellList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM10000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCustomReportCellList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCustomReportList() As System.ServiceModel.Channels.Message Implements IPYM10000StreamingService.getCustomReportList
        Dim loEx As New R_Exception
        Dim loCls As New PYM10000Cls
        Dim loRtn As New List(Of PYM10000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM10000DTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            End With
            loRtn = loCls.getCustomReportList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM10000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCustomReportList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class
