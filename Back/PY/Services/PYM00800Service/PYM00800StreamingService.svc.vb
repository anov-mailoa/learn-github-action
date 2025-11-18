Imports System.ServiceModel
Imports R_Common
Imports PYM00800Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYM00800Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00800StreamingService" in code, svc and config file together.
Public Class PYM00800StreamingService
    Implements IPYM00800StreamingService

    Public Function getPolicy() As System.ServiceModel.Channels.Message Implements IPYM00800StreamingService.getPolicy
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyCls
        Dim loRtn As New List(Of PYM00800PolicyStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM00800PolicyDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getPolicy(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00800PolicyStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPolicy")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPolicyDetailData() As System.ServiceModel.Channels.Message Implements IPYM00800StreamingService.getPolicyDetailData
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyDetailCls
        Dim loRtn As New List(Of PYM00800PolicyDetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM00800PolicyDetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPolicyCode = R_Utility.R_GetStreamingContext("cPolicyCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
            End With

            loRtn = loCls.getPolicyDetailData(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00800PolicyDetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPolicyDetailData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getMatchedPolicyData() As System.ServiceModel.Channels.Message Implements IPYM00800StreamingService.getMatchedPolicyData
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyDetailCls
        Dim loRtnTemp As List(Of PYM00800PolicyDetailStreamingDTO)
        Dim loRtn As Message
        Dim loParam As New PYM00800PolicyDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPolicyCode = R_Utility.R_GetStreamingContext("cPolicyCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cDimension1 = R_Utility.R_GetStreamingContext("cDimension1")
                .cDimension2 = R_Utility.R_GetStreamingContext("cDimension2")
                .cDimension3 = R_Utility.R_GetStreamingContext("cDimension3")
                .cDimension4 = R_Utility.R_GetStreamingContext("cDimension4")
                .cDimension5 = R_Utility.R_GetStreamingContext("cDimension5")
                .cDimension6 = R_Utility.R_GetStreamingContext("cDimension6")
                .cLookUpLanguage = R_Utility.R_GetStreamingContext("cLookUpLanguage")
            End With

            loRtnTemp = loCls.getMatchedPolicyData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00800PolicyDetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMatchedPolicyData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getAllPolicyDetail() As System.ServiceModel.Channels.Message Implements IPYM00800StreamingService.getAllPolicyDetail
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyDetailCls
        Dim loRtn As New List(Of PYM00800PolicyDetailStreamingDTO)
        Dim loRtnMessage As Message

        Try
            loRtn = loCls.getAllPolicyDetail()

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00800PolicyDetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAllPolicyDetail")


        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getUsage() As System.ServiceModel.Channels.Message Implements IPYM00800StreamingService.getUsage
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyCls
        Dim loRtn As New List(Of PYM00800PolicyStreamingDTO)
        Dim loRtnMessage As Message
        Dim loParam As New PYM00800UsageDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPolicyCode = R_Utility.R_GetStreamingContext("cPolicyCode")
                .cPolicyType = R_Utility.R_GetStreamingContext("cPolicyType")
                .cComponent = R_Utility.R_GetStreamingContext("cComponent")
            End With


            loRtn = loCls.getUsage(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00800PolicyStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getUsage")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IPYM00800StreamingService.getHistory
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyDetailCls
        Dim loRtn As New List(Of PYM00800PolicyDetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM00800PolicyDetailDTO


        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPolicyCode = R_Utility.R_GetStreamingContext("cPolicyCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
            End With
            loRtn = loCls.getHistory(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00800PolicyDetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getHistory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function RSP_GET_POLICY_HISTORY() As System.ServiceModel.Channels.Message Implements IPYM00800StreamingService.RSP_GET_POLICY_HISTORY
        Dim loEx As New R_Exception
        Dim loCls As New PYM00800PolicyDetailCls
        Dim loRtn As New List(Of PYM00800PolicyDetailStreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New PYM00800PolicyDetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPolicyCode = R_Utility.R_GetStreamingContext("cPolicyCode")
                .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
                .cReferenceDate = R_Utility.R_GetStreamingContext("cReferenceDate")
            End With
            loRtn = loCls.RSP_GET_POLICY_HISTORY(poParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM00800PolicyDetailStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "RSP_GET_POLICY_HISTORY")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

End Class
