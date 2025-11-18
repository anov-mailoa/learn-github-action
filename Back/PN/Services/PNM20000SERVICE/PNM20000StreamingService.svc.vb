Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20000Back
Imports PNM20000Common
Imports SIAPP_SERVICE_PN

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM20000StreamingService" in code, svc and config file together.
Public Class PNM20000StreamingService
    Implements IPNM20000StreamingService

    Public Function getListCanteen() As Message Implements IPNM20000StreamingService.getListCanteen
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000CanteenCLS
        Dim loRtn As List(Of PNM20000StreamingDTO)
        Dim loParam As New PNM20000DTO
        Dim loList As List(Of Byte())
        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getListCanteen(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListCanteen")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListSupplier() As Message Implements IPNM20000StreamingService.getListSupplier
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000SupplierCLS
        Dim loRtn As List(Of PNM20000StreamingDTO)
        Dim loParam As New PNM20000DTO
        Dim loList As List(Of Byte())
        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getListSupplier(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListSupplier")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListDiningTime() As Message Implements IPNM20000StreamingService.getListDiningTime
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000DiningTimeCLS
        Dim loRtn As List(Of PNM20000StreamingDTO)
        Dim loParam As New PNM20000DTO
        Dim loList As List(Of Byte())
        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getListDiningTime(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListDiningTime")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListGuest() As Message Implements IPNM20000StreamingService.getListGuest
        Dim loRtnMessage As Message = Nothing
        Dim loEx As New R_Exception
        Dim loCls As New PNM20000GuestCLS
        Dim loRtn As List(Of PNM20000StreamingDTO)
        Dim loParam As New PNM20000DTO
        Dim loList As List(Of Byte())
        Try
            loParam.CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")

            loRtn = loCls.getListGuest(loParam)
            loList = R_Utility.R_GetChunkData(Of PNM20000StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListGuest")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
