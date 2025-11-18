Imports R_Common
Imports R_Common.R_Utility
Imports System.ServiceModel.Channels
Imports ATT99100Back
Imports ATT99100Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT99100StreamingService" in code, svc and config file together.
Public Class ATT99100StreamingService
    Implements IATT99100StreamingService

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements IATT99100StreamingService.getTransaction
        Dim loException As New R_Exception
        Dim loCls As New ATT99100Cls
        Dim loRtnTemp As New List(Of ATT99100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ATT99100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cStartFrom = R_Utility.R_GetStreamingContext("cStartDate")
                .cToDate = R_Utility.R_GetStreamingContext("cToDate")
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getTransaction(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT99100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransaction")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransactionType() As System.ServiceModel.Channels.Message Implements IATT99100StreamingService.getTransactionType
        Dim loException As New R_Exception
        Dim loCls As New ATT99100Cls
        Dim loRtnTemp As New List(Of ComboBoxDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ATT99100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getTransactionType(loParam)

            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransactionType")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataGridMassLeave() As System.ServiceModel.Channels.Message Implements IATT99100StreamingService.getDataGridMassLeave
        Dim loException As New R_Exception
        Dim loCls As New ATT99100Cls
        Dim loRtnTemp As New List(Of ATT99100CommonDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ATT99100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getDataGridMassLeave(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT99100CommonDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataGridMassLeave")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataGridLeave() As System.ServiceModel.Channels.Message Implements IATT99100StreamingService.getDataGridLeave
        Dim loException As New R_Exception
        Dim loCls As New ATT99102CLS
        Dim loRtnTemp As New List(Of ATT99100Common2DTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New ATT99100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            End With

            loRtnTemp = loCls.getDataGridLeave(loParam)

            loList = R_Utility.R_GetChunkData(Of ATT99100Common2DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataGridLeave")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
