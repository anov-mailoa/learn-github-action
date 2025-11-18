Imports R_Common
Imports R_BackEnd
Imports GSM01300Back
Imports GSM01300Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01300StreamingService" in code, svc and config file together.
Public Class GSM01300StreamingService
    Implements IGSM01300StreamingService

    Public Function getActivityApprovaList() As System.ServiceModel.Channels.Message Implements IGSM01300StreamingService.getActivityApprovaList
        Dim loEx As New R_Exception
        Dim loCls As New GSM01300Cls
        Dim loRtnTemp As List(Of GSM01300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CUSER_ID = R_Utility.R_GetStreamingContext("CUSER_ID")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getActivityApprovaList(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getActivityApprovaList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getActivityApprovaUserList() As System.ServiceModel.Channels.Message Implements IGSM01300StreamingService.getActivityApprovaUserList
        Dim loEx As New R_Exception
        Dim loCls As New GSM01300UserCls
        Dim loRtnTemp As List(Of GSM01300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CAPPROVAL_CODE = R_Utility.R_GetStreamingContext("CAPPROVAL_CODE")
            End With

            loRtnTemp = loCls.getActivityApprovaUserList(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getActivityApprovaUserList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMultipleUserList() As System.ServiceModel.Channels.Message Implements IGSM01300StreamingService.getMultipleUserList
        Dim loEx As New R_Exception
        Dim loCls As New GSM01300UserCls
        Dim loRtnTemp As List(Of GSM01300StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loParam As New GSM01300DTO
        Dim loList As List(Of Byte())

        Try
            With loParam
                .CCOMPANY_ID = R_Utility.R_GetStreamingContext("CCOMPANY_ID")
                .CAPPROVAL_CODE = R_Utility.R_GetStreamingContext("CAPPROVAL_CODE")
                .LMULTIPLE = R_Utility.R_GetStreamingContext("LMULTIPLE")
            End With

            loRtnTemp = loCls.getMultipleUserList(loParam)
            loList = R_Utility.R_GetChunkData(Of GSM01300StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMultipleUserList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
