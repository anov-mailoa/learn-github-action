Imports R_BackEnd
Imports R_Common
Imports ATM00500Back
Imports System.ServiceModel.Channels
Imports ATM00500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00500StreamingService" in code, svc and config file together.
Public Class ATM00500StreamingService
    Implements IATM00500StreamingService

    Public Function getOvertime() As System.ServiceModel.Channels.Message Implements IATM00500StreamingService.getOvertime
        Dim loException As New R_Exception
        Dim loCls As New ATM00500Cls
        Dim loRtn As New List(Of ATM00500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATM00500DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            loRtn = loCls.getOvertime(poParam)
            loList = R_Utility.R_GetChunkData(Of ATM00500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "OvertimeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDetail() As System.ServiceModel.Channels.Message Implements IATM00500StreamingService.getDetail
        Dim loException As New R_Exception
        Dim loCls As New ATM00500BCls
        Dim loRtn As New List(Of ATM00500BStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATM00500BDTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cIndexCode = R_Utility.R_GetStreamingContext("cIndexCode")
            loRtn = loCls.getDetail(poParam)
            loList = R_Utility.R_GetChunkData(Of ATM00500BStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "DetailData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getJoin() As System.ServiceModel.Channels.Message Implements IATM00500StreamingService.getJoin
        Dim loException As New R_Exception
        Dim loCls As New ATM00500IndexCalcCls
        Dim loRtn As New List(Of ATM00500IndexCalcStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATM00500IndexCalcDTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUpdateBy = R_Utility.R_GetStreamingContext("cUpdateBy")
            poParam.cCreateBy = R_Utility.R_GetStreamingContext("cCreateBy")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.dDate = R_Utility.R_GetStreamingContext("dDate")
            loRtn = loCls.getJoin(poParam)
            loList = R_Utility.R_GetChunkData(Of ATM00500IndexCalcStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "JoinData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function


End Class
