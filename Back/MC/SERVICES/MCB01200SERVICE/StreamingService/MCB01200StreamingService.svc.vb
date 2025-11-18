Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports MCB01200Back
Imports R_BackEnd
Imports R_Common
Imports MCB01200Common

Public Class MCB01200StreamingService
    Implements IMCB01200StreamingService

    Public Function getChangesLogList() As System.ServiceModel.Channels.Message Implements IMCB01200StreamingService.getChangesLogList
        Dim loEx As New R_Exception
        Dim loParam As New MCB01200ChangesLogDto
        Dim loCls As New MCB01200ChangesLogCls
        Dim loRtn As List(Of MCB01200StreamingDto)
        Dim loRtnMsg As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            loParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            loParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")
            loParam.cItemType = R_Utility.R_GetStreamingContext("cItemType")
            loParam.cItemId = R_Utility.R_GetStreamingContext("cItemId")

            loRtn = loCls.getChangesLogList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB01200StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getChangesLogList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getPreviousYearList() As System.ServiceModel.Channels.Message Implements IMCB01200StreamingService.getPreviousYearList
        Dim loEx As New R_Exception
        Dim loParam As New MCB01200PreviousYearDto
        Dim loCls As New MCB01200PreviousYearCls
        Dim loRtn As List(Of MCB01200StreamingDto)
        Dim loRtnMsg As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            loParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")
            loParam.cItemType = R_Utility.R_GetStreamingContext("cItemType")
            loParam.cItemId = R_Utility.R_GetStreamingContext("cItemId")

            loRtn = loCls.getPreviousYearList(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB01200StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPreviousYearList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getCurrentYearList() As System.ServiceModel.Channels.Message Implements IMCB01200StreamingService.getCurrentYearList
        Dim loEx As New R_Exception
        Dim loParam As New MCB01200CurrentYearDto
        Dim loCls As New MCB01200CurrentYearCls
        Dim loRtn As List(Of RSP_MCB01200_PREVIOUS_USAGE_TIMES_DTO)
        Dim loRtnMsg As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            loParam.cRuleId = R_Utility.R_GetStreamingContext("cRuleId")
            loParam.cItemType = R_Utility.R_GetStreamingContext("cItemType")
            loParam.cItemId = R_Utility.R_GetStreamingContext("cItemId")

            loRtn = loCls.getCurrentYearList(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_MCB01200_PREVIOUS_USAGE_TIMES_DTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCurrentYearList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getPreviousUsage() As System.ServiceModel.Channels.Message Implements IMCB01200StreamingService.getPreviousUsage
        Dim loCls As New MCB01200CurrentYearCls
        Dim loRtnList As New List(Of RSP_DOWNLOAD_PREVIOUS_USAGE_TIMES_DTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCB01200RulesDto
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserid = R_Utility.R_GetStreamingContext("cUserId")
                .cItemId = R_Utility.R_GetStreamingContext("cItemId")
                .cItemType = R_Utility.R_GetStreamingContext("cItemType")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getPreviousUsage(poParam)

            loList = R_Utility.R_GetChunkData(Of RSP_DOWNLOAD_PREVIOUS_USAGE_TIMES_DTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getPreviousUsage")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRulesListRecord() As System.ServiceModel.Channels.Message Implements IMCB01200StreamingService.getRulesListRecord
        Dim loEx As New R_Exception
        Dim loParam As New MCB01200RulesDto
        Dim loCls As New MCB01200CurrentYearCls
        Dim loRtn As List(Of MCB01200StreamingDto)
        Dim loRtnMsg As Message = Nothing
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            loParam.cYear = R_Utility.R_GetStreamingContext("cYear")

            loRtn = loCls.getRulesListRecord(loParam)
            loList = R_Utility.R_GetChunkData(Of MCB01200StreamingDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMsg = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRulesListRecord")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMsg
    End Function

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements IMCB01200StreamingService.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New MCB01200CurrentYearCls
        Dim loRtnList As New List(Of MCB01200CommonDto)
        Dim loRtn As Message = Nothing
        Dim loParam As New MCB01200RulesDto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnList = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of MCB01200CommonDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParGrid1 As System.Collections.Generic.List(Of MCB01200Back.MCB01200RulesDto)) Implements IMCB01200StreamingService.Dummy

    End Sub
End Class
