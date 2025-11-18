Imports R_Common
Imports PYT00400Back
Imports System.ServiceModel.Channels
Imports PYT00400Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00400StreamingService" in code, svc and config file together.
Public Class PYT00400StreamingService
    Implements IPYT00400StreamingService

    Public Function GetTaxOfficeTransferTransactionList() As System.ServiceModel.Channels.Message Implements IPYT00400StreamingService.GetTaxOfficeTransferTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtnTemp As List(Of PYT00400StreamingHDDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00400HdDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtnTemp = loCls.GetTaxOfficeTransferTransactionList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00400StreamingHDDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTaxOfficeTransferTransactionList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTaxOfficeTransferTransactionListDt() As System.ServiceModel.Channels.Message Implements IPYT00400StreamingService.GetTaxOfficeTransferTransactionListDt
        Dim loEx As New R_Exception
        Dim loCls As New PYT00400DtCls
        Dim loRtnTemp As List(Of PYT00400StreamingDTDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00400DtDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cLookUpSenderFlag = R_Utility.R_GetStreamingContext("cLookUpSenderFlag")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                If .cLookUpSenderFlag = "History" Then
                    .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
                End If
            End With

            loRtnTemp = loCls.GetTaxOfficeTransferTransactionListDt(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00400StreamingDTDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTaxOfficeTransferTransactionListDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetTaxTransferTransactionHistoryHd() As System.ServiceModel.Channels.Message Implements IPYT00400StreamingService.GetTaxTransferTransactionHistoryHd
        Dim loEx As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtnTemp As List(Of PYT00400StreamingHDDTO)
        Dim loRtn As Message
        Dim loParam As New PYT00400HdDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cActivePeriod = R_Utility.R_GetStreamingContext("cActivePeriod")
                .cTransactionStatus = R_Utility.R_GetStreamingContext("cTransactionStatus")
                .cLanguage = R_Utility.R_GetStreamingContext("cLanguage")
            End With

            loRtnTemp = loCls.GetTaxTransferTransactionHistoryHd(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00400StreamingHDDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetTaxTransferTransactionHistoryHd")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYT00400StreamingService.getCmbPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYT00400HdCls
        Dim loRtn As New List(Of PYT00400StreamingHDDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00400HdDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtn = loCls.getCmbPeriod(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00400StreamingHDDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPeriod")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poPar1 As System.Collections.Generic.List(Of PYT00400Back.PYT00400GridHdDTO)) Implements IPYT00400StreamingService.Dummy

    End Sub

    Public Sub Dummy1(poPar1 As System.Collections.Generic.List(Of PYT00400Back.PYT00400GridDtDTO), poPar2 As System.Collections.Generic.List(Of PYT00400Back.PYT00400DtDTO)) Implements IPYT00400StreamingService.Dummy1

    End Sub
End Class
