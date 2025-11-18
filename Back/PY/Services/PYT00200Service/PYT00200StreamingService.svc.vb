Imports System.ServiceModel
Imports R_Common
Imports PYT00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYT00200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00200StreamingService" in code, svc and config file together.
Public Class PYT00200StreamingService
    Implements IPYT00200StreamingService

    Public Function getHeaderTransactionList() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getHeaderTransactionList
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls
        Dim loRtn As New List(Of PYT00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200HeaderDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtn = loCls.getHeaderTransactionList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHeaderTransactionListData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCurrentSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getCurrentSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls
        Dim loRtn As New List(Of PYT00200DetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200DetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtn = loCls.getCurrentSalaryGroup(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200DetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCurrentSalaryGroup")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getNewSalaryGroup() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getNewSalaryGroup
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls
        Dim loRtn As New List(Of PYT00200DetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200DetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtn = loCls.getNewSalaryGroup(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200DetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getNewSalaryGroup")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getExcelData() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getExcelData
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls
        Dim loRtn As New List(Of PYT00200ExcelStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200DetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKey")
            End With

            loRtn = loCls.getExcelData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200ExcelStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getExcelData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDetailTransaction() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getDetailTransaction
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls
        Dim loRtn As New List(Of PYT00200DetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200DetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .lView = R_Utility.R_GetStreamingContext("lView")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With
            loRtn = loCls.getDetailTransaction(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200DetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDetailTransaction")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListHistory() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getListHistory
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls
        Dim loRtn As New List(Of PYT00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200HeaderDetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cActivePeriod = R_Utility.R_GetStreamingContext("cActivePeriod")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cLookUpLanguage = R_Utility.R_GetStreamingContext("cLookUpLanguage")
            End With
            loRtn = loCls.getListHistory(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbPeriod() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getCmbPeriod
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls
        Dim loRtn As New List(Of PYT00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200HeaderDetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            End With

            loRtn = loCls.getCmbPeriod(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbPeriod")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListHistoryDetail() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getListHistoryDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200HeaderCls
        Dim loRtn As New List(Of PYT00200StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYT00200HeaderDetailDTO
    
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With
            loRtn = loCls.getListHistoryDetail(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListHistoryDetail")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy3(poPar As System.Collections.Generic.List(Of PYT00200Back.PYT00200DetailGridDTO), poPar1 As System.Collections.Generic.List(Of PYT00200Back.PYT00200HeaderDTO)) Implements IPYT00200StreamingService.Dummy3

    End Sub

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements IPYT00200StreamingService.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New PYT00200DetailCls
        Dim loRtnTemp As List(Of PYT00200BULK_DTO)
        Dim loRtn As Message
        Dim loParam As New PYT00200HeaderDetailDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnTemp = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYT00200BULK_DTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
