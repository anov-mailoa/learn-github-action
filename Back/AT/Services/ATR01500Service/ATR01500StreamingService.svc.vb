' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR01500StreamingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports ATR01500Back
Imports ATR01500Common
Imports System.ServiceModel.Channels

Public Class ATR01500StreamingService
    Implements IATR01500StreamingService

    Public Function getChkCmb() As System.ServiceModel.Channels.Message Implements IATR01500StreamingService.getChkCmb
        Dim loEx As New R_Exception
        Dim loCls As New ATR01500CLS
        Dim poParam As New ATR01500DTO
        Dim loRtnList As New List(Of ATR01500StreamingDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            End With

            loRtnList = loCls.getChkCmb(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR01500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "getChkCmb")


        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATR01500StreamingService.getData
        Dim loEx As New R_Exception
        Dim loCls As New ATR01500CLS
        Dim poParam As New ATR01500DTO
        Dim loRtnList As New List(Of ATR01500StreamingDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLeaveCodeList = R_Utility.R_GetStreamingContext("cLeaveCodeList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            End With

            loRtnList = loCls.getData(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR01500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "getData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSubData() As System.ServiceModel.Channels.Message Implements IATR01500StreamingService.getSubData
        Dim loEx As New R_Exception
        Dim loCls As New ATR01500CLS
        Dim poParam As New ATR01500DTO
        Dim loRtnList As New List(Of ATR01500StreamingDTO)
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cLeaveCodeList = R_Utility.R_GetStreamingContext("cLeaveCodeList")
                .lAllEmployee = R_Utility.R_GetStreamingContext("lAllEmployee")
                .cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getSubData(poParam)
            loList = R_Utility.R_GetChunkData(Of ATR01500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList, "getSubData")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
