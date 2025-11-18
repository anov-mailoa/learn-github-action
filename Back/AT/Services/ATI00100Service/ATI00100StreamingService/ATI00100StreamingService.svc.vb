Imports System.ServiceModel
Imports ATI00100Back
Imports ATI00100Common
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATI00100StreamingService" in code, svc and config file together.
Public Class ATI00100StreamingService
    Implements IATI00100StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IATI00100StreamingService.getData
        Dim loException As New R_Exception
        Dim loCls As New ATI00100CLS
        Dim loRtn As New List(Of ATI00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loParam As New ATI00100DTO
        Dim loList As List(Of Byte())

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            loParam.cPrintDate = R_Utility.R_GetStreamingContext("cPrintDate")
            loParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loParam.cGroupCode = R_Utility.R_GetStreamingContext("cGroupCode")
            loParam.lByEmployee = R_Utility.R_GetStreamingContext("lByEmployee")
            loParam.lByWorkGroup = R_Utility.R_GetStreamingContext("lByWorkGroup")
            loParam.cInputId = R_Utility.R_GetStreamingContext("cInputId")

            loRtn = loCls.getData(loParam)
            loList = R_Utility.R_GetChunkData(Of ATI00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmb() As System.ServiceModel.Channels.Message Implements IATI00100StreamingService.getCmb
        Dim loException As New R_Exception
        Dim loCls As New ATI00100CLS
        Dim loRtn As New List(Of ATI00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loParam As New ATI00100DTO
        Dim loList As List(Of Byte())
        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
           
            loRtn = loCls.getCmb(loParam)
            loList = R_Utility.R_GetChunkData(Of ATI00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmb")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
