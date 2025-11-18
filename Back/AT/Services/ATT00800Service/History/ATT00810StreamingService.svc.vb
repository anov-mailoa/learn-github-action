Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports ATT00800Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00810StreamingService" in code, svc and config file together.
Public Class ATT00810StreamingService
    Implements IATT00810StreamingService
     
    Public Function getHistoryList() As System.ServiceModel.Channels.Message Implements IATT00810StreamingService.getHistoryList
        Dim loException As New R_Exception
        Dim loCls As New ATT00810Cls
        Dim loRtnTemp As New List(Of ATT00800StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00810DTO
        Dim loList As List(Of Byte())

        Try
          With loParam
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferencePeriod = R_Utility.R_GetStreamingContext("cShiftPeriod")
            End With

            loRtnTemp = loCls.getHistoryList(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistoryList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy() Implements IATT00810StreamingService.Dummy

    End Sub

    Public Function getHistoryListView() As System.ServiceModel.Channels.Message Implements IATT00810StreamingService.getHistoryListView


        Dim loException As New R_Exception
        Dim loCls As New ATT00810Cls
        Dim loRtnTemp As New List(Of ATT00800StreamDTO)
        Dim loRtn As Message
        Dim loParam As New ATT00810DTO
        Dim loList As List(Of Byte())

        Try
            With loParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = (R_Utility.R_GetStreamingContext("cDeptCode"))
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getHistoryListView(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT00800StreamDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistoryListView")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class
