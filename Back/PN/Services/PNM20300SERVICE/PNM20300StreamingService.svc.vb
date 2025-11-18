Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20300Back
Imports PNM20300Common
Imports SIAPP_SERVICE_PN

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000StreamingService" in code, svc and config file together.
Public Class PNM20300StreamingService
    Implements IPNM20300StreamingService

    Public Function getListComboBox() As Message Implements IPNM20300StreamingService.getListComboBox
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20300CLS
        Dim loRtn As List(Of PNM20300StreamingDTO)
        Dim loParam As New PNM20300DTO
        Dim loList As List(Of Byte())
        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getListComboBox(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListComboBox")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListDiningDate() As Message Implements IPNM20300StreamingService.getListDiningDate
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20300CLS
        Dim loRtn As List(Of PNM20300StreamingDTO)
        Dim loParam As New PNM20300DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCANTEEN_CODE = R_Utility.R_GetStreamingContext("CCANTEEN_CODE")
                .CTIME_CODE = R_Utility.R_GetStreamingContext("CTIME_CODE")
                .LIS_EMPLOYEE = R_Utility.R_GetStreamingContext("LIS_EMPLOYEE")
                .IDAYS = R_Utility.R_GetStreamingContext("IDAYS")
            End With

            loRtn = loCls.getListDiningDate(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDiningDate")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListVisitor() As Message Implements IPNM20300StreamingService.getListVisitor
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20300CLS
        Dim loRtn As List(Of PNM20300StreamingDTO)
        Dim loParam As New PNM20300DTO
        Dim loList As List(Of Byte())
        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CCANTEEN_CODE = R_Utility.R_GetStreamingContext("CCANTEEN_CODE")
                .CTIME_CODE = R_Utility.R_GetStreamingContext("CTIME_CODE")
                .LIS_EMPLOYEE = R_Utility.R_GetStreamingContext("LIS_EMPLOYEE")
                .CDINING_DATE = R_Utility.R_GetStreamingContext("CDINING_DATE")
            End With

            loRtn = loCls.getListVisitor(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20300StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListVisitor")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
