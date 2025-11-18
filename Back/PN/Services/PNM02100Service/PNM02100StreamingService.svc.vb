Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNM02100Back
Imports PNM02100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02100StreamingService" in code, svc and config file together.
Public Class PNM02100StreamingService
    Implements IPNM02100StreamingService

    Public Function getScoreGroups() As System.ServiceModel.Channels.Message Implements IPNM02100StreamingService.getScoreGroups
        Dim loCls As New PNM02100CLS
        Dim poParam As New PNM02100ScoreGroupsDTO
        Dim loRtnTemp As List(Of PNM02100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                '.lCbInactive = R_Utility.R_GetStreamingContext("lCbInactive")
            End With

            loRtnTemp = loCls.getScoreGroups(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getScoreGroups")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getScoreInfo() As System.ServiceModel.Channels.Message Implements IPNM02100StreamingService.getScoreInfo
        Dim loCls As New PNM02100SubCLS
        Dim poParam As New PNM02100ScoreInfoDTO
        Dim loRtnTemp As List(Of PNM02100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cScoreGroup = R_Utility.R_GetStreamingContext("cScoreGroup")
            End With

            loRtnTemp = loCls.getScoreInfo(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getScoreInfo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNM02100StreamingService.getReportData
        Dim loException As New R_Exception
        Dim loCls As New PNM02100CLS
        Dim poParam As New PNM02100ScoreGroupsDTO
        Dim loRtnTemp As List(Of PNM02100ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02100ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
