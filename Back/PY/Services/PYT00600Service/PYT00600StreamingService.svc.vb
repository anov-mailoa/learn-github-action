Imports System.ServiceModel
Imports R_Common
Imports PYT00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYT00600Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00600StreamingService" in code, svc and config file together.
Public Class PYT00600StreamingService

    Implements IPYT00600StreamingService

    Public Function getCancellationList() As System.ServiceModel.Channels.Message Implements IPYT00600StreamingService.getCancellationList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00600Cls
        Dim loRtn As New List(Of PYT00600CancellationStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00600CancellationDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtn = loCls.getCancellationList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00600CancellationStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCancellationListData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCancellableList() As System.ServiceModel.Channels.Message Implements IPYT00600StreamingService.getCancellableList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00600Cls
        Dim loRtn As New List(Of PYT00600CancellationStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00600CancellableDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtn = loCls.getCancellableList(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00600CancellationStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCancellableListData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getHeaderGridData() As System.ServiceModel.Channels.Message Implements IPYT00600StreamingService.getHeaderGridData
        Dim loEx As New R_Exception
        Dim loCls As New PYT00600Cls
        Dim loRtn As New List(Of PYT00600DetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00600DetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEncryptKey = R_Utility.R_GetStreamingContext("cEncryptKey")
            End With

            loRtn = loCls.getHeaderGridData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00600DetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHeaderGridData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class
