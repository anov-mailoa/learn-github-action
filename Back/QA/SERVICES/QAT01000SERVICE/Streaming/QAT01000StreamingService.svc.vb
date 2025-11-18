Imports R_Common
Imports R_BackEnd
Imports QAT01000Back
Imports QAT01000Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT01000StreamingService" in code, svc and config file together.
Public Class QAT01000StreamingService
    Implements IQAT01000StreamingService

    Public Function getAttachmentList() As System.ServiceModel.Channels.Message Implements IQAT01000StreamingService.getAttachmentList
        Dim loException As New R_Exception
        Dim loCls As New QAT01000CLS
        Dim poParam As New QAT01000DTO
        Dim loRtnList As New List(Of QAT01000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loList As List(Of Byte())
        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
                .cRefNo = R_Utility.R_GetStreamingContext("cRefNo")
                .cTransCode = R_Utility.R_GetStreamingContext("cTransCode")
            End With

            loRtnList = loCls.getAttachmentList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAT01000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getAttachmentList")
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
