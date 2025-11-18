Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT90700Back
Imports att90700common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90700StreamingService" in code, svc and config file together.
Public Class ATT90700StreamingService
    Implements IATT90700StreamingService
     
    Public Function getDetail() As System.ServiceModel.Channels.Message Implements IATT90700StreamingService.getDetail
        Dim loRtn As New List(Of ATT90700StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90700Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT90700DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loRtn = loCls.getDetail(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT90700StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATT90700StreamingService.getHistory
        Dim loRtn As New List(Of ATT90700StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90700Cls
        Dim loEx As New R_Exception
        Dim loParam As New ATT90700DTO
        Dim loChunk As New List(Of Byte())


        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loParam.cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")
            loRtn = loCls.getHistory(loParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT90700StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getLeaveBeginning() As System.ServiceModel.Channels.Message Implements IATT90700StreamingService.getLeaveBeginning
        Dim loRtn As New List(Of ATT90700StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90700Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcLangId As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            pcLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getLeaveBeginning(pcCompId, pcUserId, pcLangId)
            loChunk = R_Utility.R_GetChunkData(Of ATT90700StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLeaveBeginning")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getXML() As System.ServiceModel.Channels.Message Implements IATT90700StreamingService.getXML
        Dim loRtn As New List(Of ATT90700StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90700Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcGuid As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            pcGuid = R_Utility.R_GetStreamingContext("cGuid")
            loRtn = loCls.getXML(pcCompId, pcUserId, pcGuid)
            loChunk = R_Utility.R_GetChunkData(Of ATT90700StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getXML")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getLeaveDesc() As System.ServiceModel.Channels.Message Implements IATT90700StreamingService.getLeaveDesc
        Dim loRtn As New List(Of ATT90700ExceDesclDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90700Cls
        Dim loEx As New R_Exception 
        Dim loChunk As New List(Of Byte())
        Dim loParam As New ATT90700DTO

        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getLeaveDesc(loParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT90700ExceDesclDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLeaveDesc")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class
