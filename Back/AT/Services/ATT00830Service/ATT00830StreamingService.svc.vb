' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00830StreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00830Back
Imports ATT00830Common
Imports System.ServiceModel.Channels

Public Class ATT00830StreamingService
    Implements IATT00830StreamingService
     
    Public Function getHolidayLookup() As System.ServiceModel.Channels.Message Implements IATT00830StreamingService.getHolidayLookup
        Dim loRtn As New List(Of ATT00830DetailDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00830CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00830DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")

            loRtn = loCls.getHolidayLookup(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00830DetailDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHolidayLookup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getHolidayTransaction() As System.ServiceModel.Channels.Message Implements IATT00830StreamingService.getHolidayTransaction
        Dim loRtn As New List(Of ATT00830StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00830CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00830DTO
        Dim loChunk As New List(Of Byte())

        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            poParam.LHISTORY = R_Utility.R_GetStreamingContext("LHISTORY")
            poParam.CREFERENCE_PERIOD = R_Utility.R_GetStreamingContext("CREFERENCE_PERIOD")

            loRtn = loCls.getHolidayTransaction(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00830StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHolidayTransaction")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getHolidayTransactionDetail() As System.ServiceModel.Channels.Message Implements IATT00830StreamingService.getHolidayTransactionDetail

        Dim loRtn As New List(Of ATT00830DetailDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00830CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00830DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
            poParam.CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")

            loRtn = loCls.getHolidayTransactionDetail(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00830DetailDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHolidayTransactionDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function
End Class
