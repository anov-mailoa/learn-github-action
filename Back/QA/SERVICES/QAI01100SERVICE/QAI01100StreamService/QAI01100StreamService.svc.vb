Imports R_Common
Imports QAI01100Back
Imports System.ServiceModel.Channels
Imports QAI01100Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI01100StreamService" in code, svc and config file together.
Public Class QAI01100StreamService
    Implements IQAI01100StreamService

    Public Function GetSOCATTLIST() As System.ServiceModel.Channels.Message Implements IQAI01100StreamService.GetSOCATTLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI01100Cls
        Dim loRtnTemp As List(Of QAI01100StreamDto)
        Dim loParam As New QAI01100Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
        End With

        Try
            loRtnTemp = loCls.GetSOCATTLIST(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAI01100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)


            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetSOCATTLIST")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetSOCDOCLIST() As System.ServiceModel.Channels.Message Implements IQAI01100StreamService.GetSOCDOCLIST
        Dim loException As New R_Exception
        Dim loCls As New QAI01100Cls
        Dim loRtnTemp As List(Of QAI01100StreamDto)
        Dim loParam As New QAI01100Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode")
            .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            .cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
        End With

        Try
            loRtnTemp = loCls.GetSOCDOCLIST(loParam)


            loChunk = R_Utility.R_GetChunkData(Of QAI01100StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetSOCDOCLIST")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
