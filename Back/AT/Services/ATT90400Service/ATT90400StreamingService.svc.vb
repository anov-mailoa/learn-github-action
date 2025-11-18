Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATT90400Common
Imports ATT90400Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90400StreamingService" in code, svc and config file together.
Public Class ATT90400StreamingService
    Implements IATT90400StreamingService
     
    Public Function getAdditional() As System.ServiceModel.Channels.Message Implements IATT90400StreamingService.getAdditional
        Dim loRtn As New List(Of ATT90400StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90400Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcLangId As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            pcLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getAdditional(pcCompId, pcUserId, pcLangId)
            loChunk = R_Utility.R_GetChunkData(Of ATT90400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getAdditional")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATT90400StreamingService.getHistory
        Dim loRtn As New List(Of ATT90400StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90400Cls
        Dim loEx As New R_Exception
        Dim loParam As New ATT90400DTO
        Dim loChunk As New List(Of Byte())
         
        Try

            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loParam.cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")
            loRtn = loCls.getHistory(loParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT90400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getEmployeeDetail() As System.ServiceModel.Channels.Message Implements IATT90400StreamingService.getEmployeeDetail
        Dim loRtn As New List(Of ATT90400StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90400Cls
        Dim loEx As New R_Exception
        Dim loParam As New ATT90400DTO
        Dim loChunk As New List(Of Byte())


        Try
            loParam.CENTITLEMENT_DATE = R_Utility.R_GetStreamingContext("CENTITLEMENT_DATE")
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            loParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            loParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
             
            loRtn = loCls.getEmployeeDetail(loParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT90400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getEmployeeDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPopUpEmployee() As System.ServiceModel.Channels.Message Implements IATT90400StreamingService.getPopUpEmployee
        Dim loRtn As New List(Of ATT90400StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT90400Cls
        Dim loEx As New R_Exception
        Dim loParam As New ATT90400DTO
        Dim loChunk As New List(Of Byte())


        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.CENTITLEMENT_DATE = R_Utility.R_GetStreamingContext("CENTITLEMENT_DATE")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getPopUpEmployee(loParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT90400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPopUpEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class
