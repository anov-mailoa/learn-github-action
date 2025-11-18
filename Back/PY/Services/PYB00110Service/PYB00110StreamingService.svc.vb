Imports System.ServiceModel
Imports R_Common
Imports PYB00110Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYB00110Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYB00110StreamingService" in code, svc and config file together.
Public Class PYB00110StreamingService
    Implements IPYB00110StreamingService

    Public Function getAvailableInterfaceList() As System.ServiceModel.Channels.Message Implements IPYB00110StreamingService.getAvailableInterfaceList
        Dim loEx As New R_Exception
        Dim loCls As New PYB00100HeaderCls
        Dim loRtn As New List(Of PYB00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYB00100HeaderDTO
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
            End With

            loRtn = loCls.getAvailableList(poParam)


            loList = R_Utility.R_GetChunkData(Of PYB00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAvailableInterfaceList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDetailInterfaceList() As System.ServiceModel.Channels.Message Implements IPYB00110StreamingService.getDetailInterfaceList
        Dim loEx As New R_Exception
        Dim loCls As New PYB00100HeaderCls
        Dim loRtn As New List(Of PYB00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYB00100HeaderDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
                .cInterface = R_Utility.R_GetStreamingContext("cInterface")
                .cPeriodIndex = R_Utility.R_GetStreamingContext("cPeriodIndex")
                .cKey = R_Utility.R_GetStreamingContext("cKey")
                .lFestivalFlag = R_Utility.R_GetStreamingContext("lFestivalFlag")
            End With
            loRtn = loCls.getDetailList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDetailInterfaceList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getProcessedInterfaceList() As System.ServiceModel.Channels.Message Implements IPYB00110StreamingService.getProcessedInterfaceList
        Dim loEx As New R_Exception
        Dim loCls As New PYB00100HeaderCls
        Dim loRtn As New List(Of PYB00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYB00100HeaderDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPaymentType = R_Utility.R_GetStreamingContext("cPaymentType")
            End With
            loRtn = loCls.getProcessedList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYB00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcessedInterfaceList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poDetail As System.Collections.Generic.List(Of PYB00110Back.PYB00100DetailDTO)) Implements IPYB00110StreamingService.Dummy

    End Sub
End Class
