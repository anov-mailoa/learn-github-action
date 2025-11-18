Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20100Back
Imports PNM20100Common
Imports SIAPP_SERVICE_PN

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000StreamingService" in code, svc and config file together.
Public Class PNM20100StreamingService
    Implements IPNM20100StreamingService

    Public Function getListComboBox() As Message Implements IPNM20100StreamingService.getListComboBox
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20100CLS
        Dim loRtn As List(Of PNM20100StreamingDTO)
        Dim loParam As New PNM20100DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CDINING_DATE = R_Utility.R_GetStreamingContext("CDINING_DATE")
            End With

            loRtn = loCls.getListComboBox(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListComboBox")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListDiningSchedule() As Message Implements IPNM20100StreamingService.getListDiningSchedule
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20100CLS
        Dim loRtn As List(Of PNM20100StreamingDTO)
        Dim loParam As New PNM20100DTO
        Dim loList As List(Of Byte())
        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            loParam.CCANTEEN_CODE = R_Utility.R_GetStreamingContext("CCANTEEN_CODE")
            loParam.CTIME_CODE = R_Utility.R_GetStreamingContext("CTIME_CODE")

            loRtn = loCls.getListDiningSchedule(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDiningSchedule")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class
