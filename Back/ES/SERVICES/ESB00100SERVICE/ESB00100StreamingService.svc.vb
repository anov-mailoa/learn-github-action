Imports R_Common
Imports ESB00100Back
Imports ESB00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESB00100StreamingService" in code, svc and config file together.
Public Class ESB00100StreamingService
    Implements IESB00100StreamingService

    Public Function getApproverList() As System.ServiceModel.Channels.Message Implements IESB00100StreamingService.getApproverList
        Dim loEx As New R_Exception
        Dim loCls As New ESB00100CLS
        Dim loRtnTemp As List(Of ESB00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESB00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .LHISTORY = R_Utility.R_GetStreamingContext("LHISTORY")
            End With

            loRtnTemp = loCls.getApproverList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESB00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getApproverList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTrxList() As System.ServiceModel.Channels.Message Implements IESB00100StreamingService.getTrxList
        Dim loEx As New R_Exception
        Dim loCls As New ESB00100CLS
        Dim loRtnTemp As List(Of ESB00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESB00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CAPPROVER_ID = R_Utility.R_GetStreamingContext("CAPPROVER_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnTemp = loCls.getTrxList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESB00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTrxList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As ESB00100Back.ESB00100DTO) Implements IESB00100StreamingService.Dummy

    End Sub

    Public Function getHistoryTrxList() As System.ServiceModel.Channels.Message Implements IESB00100StreamingService.getHistoryTrxList
        Dim loEx As New R_Exception
        Dim loCls As New ESB00100CLS
        Dim loRtnTemp As List(Of ESB00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESB00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CFROM_DATE = R_Utility.R_GetStreamingContext("CFROM_DATE")
                .CTO_DATE = R_Utility.R_GetStreamingContext("CTO_DATE")
                .COVERRIDE_BY = R_Utility.R_GetStreamingContext("COVERRIDE_BY")
                .CAPPROVER_ID = R_Utility.R_GetStreamingContext("CAPPROVER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
            End With

            loRtnTemp = loCls.getHistoryTrxList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESB00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistoryTrxList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getUserList() As System.ServiceModel.Channels.Message Implements IESB00100StreamingService.getUserList
        Dim loEx As New R_Exception
        Dim loCls As New ESB00100CLS
        Dim loRtnTemp As List(Of ESB00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESB00100DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
            End With

            loRtnTemp = loCls.getUserList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESB00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUserList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getViewDetail(poParam As ESB00100Back.ESB00100ViewDetailDTO) As ESB00100Back.ESB00100ViewDetailDTO Implements IESB00100StreamingService.getViewDetail
        Dim loEx As New R_Exception
        Dim loCls As New ESB00100CLS
        Dim loRtn As New ESB00100ViewDetailDTO

        Try

            loRtn = loCls.getViewDetail(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDetailSubItem(poParam As ESB00100Back.ESB00100ViewDetailDTO) As ESB00100Back.ESB00100ViewDetailDTO Implements IESB00100StreamingService.getDetailSubItem
        Dim loEx As New R_Exception
        Dim loCls As New ESB00100CLS
        Dim loRtn As New ESB00100ViewDetailDTO

        Try

            loRtn = loCls.getDetailSubItem(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetSubItemsList() As System.ServiceModel.Channels.Message Implements IESB00100StreamingService.GetSubItemsList
        Dim loEx As New R_Exception
        Dim loCls As New ESB00100CLS
        Dim loRtnTemp As List(Of ESB00100StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New ESB00100ViewDetailDTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CTRANSACTION_CODE = R_Utility.R_GetStreamingContext("CTRANSACTION_CODE")
                .CDEPT_CODE = R_Utility.R_GetStreamingContext("CDEPT_CODE")
                .CREFERENCE_NO = R_Utility.R_GetStreamingContext("CREFERENCE_NO")
                .CEMPLOYEE_ID = R_Utility.R_GetStreamingContext("CEMPLOYEE_ID")
                .CENC_KEY = R_Utility.R_GetStreamingContext("ENCKEY")
            End With

            loRtnTemp = loCls.GetSubItemsList(loParam)

            loList = R_Utility.R_GetChunkData(Of ESB00100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetSubItemsList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
