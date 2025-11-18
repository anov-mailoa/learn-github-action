Imports System.ServiceModel
Imports R_Common
Imports PYT00800Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYT00800Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00800StreamingService" in code, svc and config file together.
Public Class PYT00800StreamingService

    Implements IPYT00800StreamingService

    Public Function GetTransList() As System.ServiceModel.Channels.Message Implements IPYT00800StreamingService.GetTransList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800Cls
        Dim loRtnTemp As List(Of PYT00800GridDTOnon)
        Dim loRtn As Message
        Dim loParam As New PYT00800DTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CCULTURE_ID = R_Utility.R_GetStreamingContext("CCULTURE_ID")
            End With

            loRtnTemp = loCls.GetTransList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00800GridDTOnon)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of PYT00800Back.PYT00800GridDTO)) Implements IPYT00800StreamingService.Dummy

    End Sub

    Public Function GetTransDetail() As System.ServiceModel.Channels.Message Implements IPYT00800StreamingService.GetTransDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800DetailCls
        Dim loRtnTemp As List(Of PYT00800DetailStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00800DetailDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .LREPLACE_CHANGED_VALUE = R_Utility.R_GetStreamingContext("LREPLACE_CHANGED_VALUE")
                .CEMP_LIST = R_Utility.R_GetStreamingContext("CEMP_LIST")
            End With

            loRtnTemp = loCls.GetTransDetail(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00800DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTransDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IPYT00800StreamingService.getEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800HistoryCls
        Dim loRtnTemp As List(Of PYT00800HistoryDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00800HistoryDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CENC_KEY = R_Utility.R_GetStreamingContext("CENC_KEY")
            End With

            loRtnTemp = loCls.getEmployee(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00800HistoryDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getEmployee")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransaction() As System.ServiceModel.Channels.Message Implements IPYT00800StreamingService.getTransaction
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800HistoryCls
        Dim loRtnTemp As List(Of PYT00800HistoryDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00800HistoryDTO

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CSTATUS_ID = R_Utility.R_GetStreamingContext("CSTATUS_ID")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
            End With

            loRtnTemp = loCls.getTransaction(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00800HistoryDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransaction")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
