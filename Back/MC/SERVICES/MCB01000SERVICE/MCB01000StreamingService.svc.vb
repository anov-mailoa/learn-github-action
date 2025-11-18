Imports System.ServiceModel.Channels
Imports R_Common
Imports MCB01000Back
Imports MCB01000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCB01000StreamingService" in code, svc and config file together.
Public Class MCB01000StreamingService
    Implements IMCB01000StreamingService

    Public Function getMcmCutOffValue() As System.ServiceModel.Channels.Message Implements IMCB01000StreamingService.getMcmCutOffValue
        Dim loCls As New MCB01000Cls
        Dim loRtnList As New List(Of MCB01000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCB01000GridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())
        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getMcmCutOffValue(poParam)

            loList = R_Utility.R_GetChunkData(Of MCB01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getMcmCutOffValue")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getUsage() As System.ServiceModel.Channels.Message Implements IMCB01000StreamingService.getUsage
        Dim loCls As New MCB01000Cls
        Dim loRtnList As New List(Of MCB01000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim poParam As New MCB01000GridDTO
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cYear = R_Utility.R_GetStreamingContext("cYear")
                .cEncKey = R_Utility.R_GetStreamingContext("cEncKey")
            End With

            loRtnList = loCls.getUsage(poParam)
            loList = R_Utility.R_GetChunkData(Of MCB01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getUsage")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam As System.Collections.Generic.List(Of MCB01000Back.MCB01000GridDTO)) Implements IMCB01000StreamingService.Dummy

    End Sub

    Public Function getErrorData() As System.ServiceModel.Channels.Message Implements IMCB01000StreamingService.getErrorData
        Dim loEx As New R_Exception
        Dim loCls As New MCB01000UploadCls
        Dim loRtnList As New List(Of MCB01000UploadExcelDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New MCB01000DTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnList = loCls.getErrorData(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of MCB01000UploadExcelDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getErrorData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
