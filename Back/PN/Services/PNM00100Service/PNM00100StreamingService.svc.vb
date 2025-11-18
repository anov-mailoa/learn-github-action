Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PNM00100Back
Imports PNM00100Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM00100StreamingService" in code, svc and config file together.
Public Class PNM00100StreamingService
    Implements IPNM00100StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IPNM00100StreamingService.getData
        Dim loCls As New PNM00100FullNameCLS
        Dim poParam As New PNM00100FullNameDTO
        Dim loRtnTemp As List(Of PNM00100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IPNM00100StreamingService.getHistory
        Dim loCls As New PNM00100HistoryCLS
        Dim poParam As New PNM00100HistoryDTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNM00100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getHistory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetLocalCurrency() As System.ServiceModel.Channels.Message Implements IPNM00100StreamingService.GetLocalCurrency
        Dim loRtnMessage As Message
        Dim loEx As New R_Exception
        Dim loCls As New PNM00100CLS
        Dim loRtn As List(Of PNM00100StreamingDTO)
        Dim loParam As New PNM00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtn = loCls.GetLocalCurrency(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetLocalCurrency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getSourceList() As System.ServiceModel.Channels.Message Implements IPNM00100StreamingService.getSourceList
        Dim loCls As New PNM00100FullNameCLS
        Dim poParam As New PNM00100FullNameDTO
        Dim loRtnTemp As List(Of PNM00100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getSourceList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSourceList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetFullNameList() As System.ServiceModel.Channels.Message Implements IPNM00100StreamingService.GetFullNameList
        Dim loCls As New PNM00100FullNameCLS
        Dim poParam As New PNM00100FullNameDTO
        Dim loRtnTemp As List(Of PNM00100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.GetFullNameList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetFullNameList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
