Imports R_Common
Imports System.ServiceModel.Channels
Imports MCM00500Back
Imports MCM00500Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "MCM00500StreamingService" in code, svc and config file together.
Public Class MCM00500StreamingService
    Implements IMCM00500StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IMCM00500StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New MCM00500Cls
        Dim loRtn As New List(Of MCM00500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New MCM00500DetailDTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getData(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM00500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPermissionCategory() As System.ServiceModel.Channels.Message Implements IMCM00500StreamingService.getPermissionCategory
        Dim loCls As New MCM00500Cls
        Dim poParam As New MCM00500DetailDTO
        Dim loRtnList As New List(Of MCM00500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
            End With

            loRtnList = loCls.getPermissionCategory(poParam)

            loList = R_Utility.R_GetChunkData(Of MCM00500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getPermissionCategory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getUserList() As System.ServiceModel.Channels.Message Implements IMCM00500StreamingService.getUserList
        Dim loCls As New MCM00500Cls
        Dim poParam As New MCM00500HeaderDTO
        Dim loRtnList As New List(Of MCM00500StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loList As List(Of Byte())

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnList = loCls.getUserList(poParam)
            loList = R_Utility.R_GetChunkData(Of MCM00500StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable(), "getUserList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poReport As System.Collections.Generic.List(Of MCM00500Back.MCM00500ReportDTO), poparam2 As System.Collections.Generic.List(Of MCM00500Back.MCM00500HeaderDTO)) Implements IMCM00500StreamingService.Dummy

    End Sub
End Class
