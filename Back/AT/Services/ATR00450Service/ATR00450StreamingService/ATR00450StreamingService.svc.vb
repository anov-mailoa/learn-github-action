Imports R_BackEnd
Imports R_Common
Imports ATR00450Back
Imports ATR00450Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATR00450StreamingService" in code, svc and config file together.
Public Class ATR00450StreamingService
    Implements IATR00450StreamingService

    Public Function getSP() As System.ServiceModel.Channels.Message Implements IATR00450StreamingService.getSP
        Dim loException As New R_Exception
        Dim loCls As New ATR00450Cls
        Dim loRtn As New List(Of ATR00450StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR00450DTO
        Dim loList As List(Of Byte())

        Try
            poParam.COMPANY_ID = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cEmployeeList = R_Utility.R_GetStreamingContext("cEmployeeList")
            poParam.REASON_TYPE = R_Utility.R_GetStreamingContext("cReasonType")
            poParam.cReasonList = R_Utility.R_GetStreamingContext("cReasonList")
            poParam.cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
            poParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.lIsAllEmployee = R_Utility.R_GetStreamingContext("lIsAllEmployee")

            loRtn = loCls.getSP(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00450StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "SPData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getAllEmployee() As System.ServiceModel.Channels.Message Implements IATR00450StreamingService.getAllEmployee
        Dim loException As New R_Exception
        Dim loCls As New ATR00450Cls
        Dim loRtn As New List(Of ATR00450StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR00450DTO
        Dim loList As List(Of Byte())

        Try
            poParam.COMPANY_ID = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.dDate = R_Utility.R_GetStreamingContext("dDate")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getAllEmployee(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00450StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loRtn.AsEnumerable, "AllEmployeeData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListView() As System.ServiceModel.Channels.Message Implements IATR00450StreamingService.getListView
        Dim loException As New R_Exception
        Dim loCls As New ATR00450Cls
        Dim loRtn As New List(Of ATR00450ListViewStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New ATR00450ListViewDTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cReasonType = R_Utility.R_GetStreamingContext("cReasonType")

            loRtn = loCls.getListView(poParam)

            loList = R_Utility.R_GetChunkData(Of ATR00450ListViewStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "ListViewData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function


    Public Sub Dummy(poParGrid As System.Collections.Generic.List(Of ATR00450Back.ATR00450ListViewDTO), POpar1 As System.Collections.Generic.List(Of ATR00450Back.ATR00450DTO)) Implements IATR00450StreamingService.Dummy

    End Sub
End Class
