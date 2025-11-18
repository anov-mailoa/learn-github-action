' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00110StreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00110Back
Imports ATT00110Common
Imports System.ServiceModel.Channels

Public Class ATT00110StreamingService
    Implements IATT00110StreamingService
     
    Public Function getRSP_AT_GET_EXCESS_FOR_OVERTIME() As System.ServiceModel.Channels.Message Implements IATT00110StreamingService.getRSP_AT_GET_EXCESS_FOR_OVERTIME
        Dim loRtn As New List(Of RSP_AT_GET_EXCESS_FOR_OVERTIMEDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00110CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00110DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
            poParam.CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
            poParam.CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
            poParam.CDATE_TYPE = R_Utility.R_GetStreamingContext("CDATE_TYPE")

            loRtn = loCls.getRSP_AT_GET_EXCESS_FOR_OVERTIME(poParam)
            loChunk = R_Utility.R_GetChunkData(Of RSP_AT_GET_EXCESS_FOR_OVERTIMEDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getRSP_AT_GET_EXCESS_FOR_OVERTIME")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getWorkingOrder() As System.ServiceModel.Channels.Message Implements IATT00110StreamingService.getWorkingOrder
        Dim loRtn As New List(Of ATT00110StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00110CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00110DTO
        Dim loChunk As New List(Of Byte())

        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")

            loRtn = loCls.getWorkingOrder(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00110StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getWorkingOrder")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getWorkingOrderDT() As System.ServiceModel.Channels.Message Implements IATT00110StreamingService.getWorkingOrderDT

        Dim loRtn As New List(Of RSP_AT_GET_EXCESS_FOR_OVERTIMEDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00110CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATT00110DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
            poParam.CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
            'poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            'poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")

            loRtn = loCls.getWorkingOrderDT(poParam)
            loChunk = R_Utility.R_GetChunkData(Of RSP_AT_GET_EXCESS_FOR_OVERTIMEDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getWorkingOrderDT")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function
End Class
