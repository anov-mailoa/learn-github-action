Imports R_Common
Imports R_BackEnd
Imports MCT02100Back
Imports System.ServiceModel.Channels
Imports MCT02100Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM02100StreamingService" in code, svc and config file together.
Public Class MCT02100StreamingService
    Implements IMCT02100StreamingService

    Public Function gvListHeader() As System.ServiceModel.Channels.Message Implements IMCT02100StreamingService.gvListHeader
        Dim loRtn As New List(Of MCT02100GvStreamDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCT02100Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCT02100Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cKeyId = R_Utility.R_GetStreamingContext("cKeyId")

            loRtn = loCls.gvListHeader(poParam)
            loList = R_Utility.R_GetChunkData(Of MCT02100GvStreamDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "gvListHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function gvListDetail() As System.ServiceModel.Channels.Message Implements IMCT02100StreamingService.gvListDetail
        Dim loRtn As New List(Of MCT02100DetailStreamGvDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCT02100Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCT02100Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cKeyId = R_Utility.R_GetStreamingContext("cKeyId")

            loRtn = loCls.gvListDetail(poParam)
            loList = R_Utility.R_GetChunkData(Of MCT02100DetailStreamGvDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "gvListDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function DownloadPartnerMember() As System.ServiceModel.Channels.Message Implements IMCT02100StreamingService.DownloadPartnerMember
        Dim loRtn As New List(Of DownloadPartnerMemberNonDto)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New MCT02100Cls
        Dim loEx As New R_Exception
        Dim poParam As New MCT02100Dto
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cPartnerId = R_Utility.R_GetStreamingContext("cPartnerId")
            poParam.cYear = R_Utility.R_GetStreamingContext("cYear")
            poParam.cKeyId = R_Utility.R_GetStreamingContext("cEncryptKey")

            loRtn = loCls.DownloadPartnerMember(poParam)
            loList = R_Utility.R_GetChunkData(Of DownloadPartnerMemberNonDto)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "DownloadPartnerMember")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements IMCT02100StreamingService.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls
        Dim loRtnList As New List(Of MCT02100CommonDto)
        Dim loRtn As Message = Nothing
        Dim loParam As New MCT02100Dto

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnList = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of MCT02100CommonDto)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poPar As System.Collections.Generic.List(Of MCT02100Back.MCT02100GvDto), poPar4 As System.Collections.Generic.List(Of MCT02100Back.DownloadPartnerMemberDto)) Implements IMCT02100StreamingService.Dummy

    End Sub
End Class
