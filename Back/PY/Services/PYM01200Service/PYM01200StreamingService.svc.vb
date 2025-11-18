Imports System.ServiceModel
Imports R_Common
Imports PYM01200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYM01200Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01200StreamingService" in code, svc and config file together.
Public Class PYM01200StreamingService
    Implements IPYM01200StreamingService

    Public Function getSalaryGroupEmployee() As System.ServiceModel.Channels.Message Implements IPYM01200StreamingService.getSalaryGroupEmployee
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200SalaryHeaderCls
        Dim loRtn As New List(Of PYM01200SalaryHeaderStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01200SalaryHeaderDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With
            loRtn = loCls.getSalaryGroupEmployee(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01200SalaryHeaderStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSalaryGroupEmployee")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getTransferHeaderData() As System.ServiceModel.Channels.Message Implements IPYM01200StreamingService.getTransferHeaderData
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls
        Dim loRtn As New List(Of PYM01200TransferHeaderStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01200TransferHeaderDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtn = loCls.getTransferHeaderData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01200TransferHeaderStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransferHeaderData")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getTransferDetail() As System.ServiceModel.Channels.Message Implements IPYM01200StreamingService.getTransferDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls
        Dim loRtn As New List(Of PYM01200BankAccountStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01200TransferHeaderDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEncryptKey = R_Utility.R_GetStreamingContext("cEncryptKey")
                .cTransferCode = R_Utility.R_GetStreamingContext("cTransferCode")
            End With

            loRtn = loCls.getTransferDetail(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01200BankAccountStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTransferDetail")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getProcessList() As System.ServiceModel.Channels.Message Implements IPYM01200StreamingService.getProcessList
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200ComponentCls
        Dim loRtn As New List(Of PYM01200ComponentStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01200ComponentDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            End With

            loRtn = loCls.getProcessList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01200ComponentStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getProcessList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getComponentList() As System.ServiceModel.Channels.Message Implements IPYM01200StreamingService.getComponentList
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200ComponentCls
        Dim loRtn As New List(Of PYM01200ComponentStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01200ComponentDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
                .cEncryptKey = R_Utility.R_GetStreamingContext("cEncryptKey")
                .cProcessCode = R_Utility.R_GetStreamingContext("cProcessCode")
            End With

            loRtn = loCls.getComponentList(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01200ComponentStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComponentList")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getUserDefineParams() As System.ServiceModel.Channels.Message Implements IPYM01200StreamingService.getUserDefineParams
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200UserDefineParamCls
        Dim loRtn As New List(Of PYM01200UserDefineParamStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01200UserDefineParamDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtn = loCls.getUserDefineParams(poParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM01200UserDefineParamStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUserDefineParams")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function



    Public Function getBankNumber() As System.ServiceModel.Channels.Message Implements IPYM01200StreamingService.getBankNumber
        Dim loEx As New R_Exception
        Dim loCls As New PYM01200TransferHeaderCls
        Dim loRtn As New List(Of ComboBoxDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM01200TransferHeaderDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            End With

            loRtn = loCls.getBankNumber(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getBankNumber")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poComponentCarrier As System.Collections.Generic.List(Of PYM01200Back.PYM01200ComponentDTO), poParam2 As System.Collections.Generic.List(Of PYM01200Back.PYM01200TransferHeaderGridDTO)) Implements IPYM01200StreamingService.Dummy

    End Sub
End Class
