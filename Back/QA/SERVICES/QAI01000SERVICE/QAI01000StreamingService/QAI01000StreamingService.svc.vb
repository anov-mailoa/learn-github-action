Imports R_BackEnd
Imports R_Common
Imports QAI01000Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports QAI01000Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI01000StreamingService" in code, svc and config file together.
Public Class QAI01000StreamingService
    Implements IQAI01000StreamingService

    Public Function getListDepartmentGrid() As System.ServiceModel.Channels.Message Implements IQAI01000StreamingService.getListDepartmentGrid
        Dim loException As New R_Exception
        Dim loCls As New QAI01000CLS
        Dim loRtn As New List(Of QAI01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAI01000DTO
        Dim loChunk As New List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getListDepartmentGrid(poParam)


            loChunk = R_Utility.R_GetChunkData(Of QAI01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)


            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListDepartmentGrid")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPrintReport() As System.ServiceModel.Channels.Message Implements IQAI01000StreamingService.getPrintReport
        Dim loException As New R_Exception
        Dim loCls As New QAI01000CLS
        Dim loRtn As New List(Of QAI01000StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAI01000DTO
        Dim loChunk As New List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cStatusList = R_Utility.R_GetStreamingContext("cStatusList")
            poParam.cOwnerList = R_Utility.R_GetStreamingContext("cOwnerList")
            poParam.lRefDate = R_Utility.R_GetStreamingContext("lRefDate")
            poParam.cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
            poParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")


            loRtn = loCls.getPrintReport(poParam)


            loChunk = R_Utility.R_GetChunkData(Of QAI01000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPrintReport")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
