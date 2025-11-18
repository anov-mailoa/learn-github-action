' NOTE: You can use the "Rename" command on the context menu to change the class name "ATB00800StreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATB00800Back
Imports ATB00800Common
Imports System.ServiceModel.Channels

Public Class ATB00800StreamingService
    Implements IATB00800StreamingService
     
    Public Function getSearchEmployee() As System.ServiceModel.Channels.Message Implements IATB00800StreamingService.getSearchEmployee
        Dim loRtn As New List(Of ATB00800SearchDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00800CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATB00800DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            poParam.CSTART_DATE = R_Utility.R_GetStreamingContext("CSTART_DATE")
            poParam.CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
            poParam.CPROC_BY = R_Utility.R_GetStreamingContext("CPROC_BY")
            poParam.CPROC_BY_VALUE = R_Utility.R_GetStreamingContext("CPROC_BY_VALUE")

            loRtn = loCls.getSearchEmployee(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATB00800SearchDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getSearchEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getPresentProcess() As System.ServiceModel.Channels.Message Implements IATB00800StreamingService.getPresentProcess
        Dim loRtn As New List(Of ATB00800StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00800CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATB00800DTO
        Dim loChunk As New List(Of Byte())

        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")

            loRtn = loCls.getPresentProcess(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATB00800StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPresentProcess")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getPresentProcessDetail() As System.ServiceModel.Channels.Message Implements IATB00800StreamingService.getPresentProcessDetail

        Dim loRtn As New List(Of ATB00800SearchDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00800CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATB00800DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            poParam.CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
            poParam.CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
            poParam.CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")

            loRtn = loCls.getPresentProcessDetail(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATB00800SearchDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPresentProcessDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getLookUpWorkGroup() As System.ServiceModel.Channels.Message Implements IATB00800StreamingService.getLookUpWorkGroup

        Dim loRtn As New List(Of ATB00800StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00800CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATB00800DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getLookUpWorkGroup(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATB00800StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLookUpWorkGroup")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getPresentProcessHistory() As System.ServiceModel.Channels.Message Implements IATB00800StreamingService.getPresentProcessHistory
        Dim loRtn As New List(Of ATB00800StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00800CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATB00800DTO
        Dim loChunk As New List(Of Byte())

        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            poParam.CREFERENCE_PERIOD = R_Utility.R_GetStreamingContext("CREFERENCE_PERIOD")

            loRtn = loCls.getPresentProcessHistory(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATB00800StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPresentProcessHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getPresentProcessInquiry() As System.ServiceModel.Channels.Message Implements IATB00800StreamingService.getPresentProcessInquiry
        Dim loRtn As New List(Of ATB00800StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATB00800CLS
        Dim loEx As New R_Exception
        Dim poParam As New ATB00800DTO
        Dim loChunk As New List(Of Byte())

        Try

            poParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            poParam.CLANGUAGE_ID = R_Utility.R_GetStreamingContext("CLANGUAGE_ID")
            poParam.CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            poParam.CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")

            loRtn = loCls.getPresentProcessInquiry(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATB00800StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPresentProcessInquiry")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

End Class
