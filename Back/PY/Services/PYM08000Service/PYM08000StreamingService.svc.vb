Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM08000Back
Imports PYM08000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM08000StreamingService" in code, svc and config file together.
Public Class PYM08000StreamingService
    Implements IPYM08000StreamingService

    Public Function getGLHeader() As System.ServiceModel.Channels.Message Implements IPYM08000StreamingService.getGLHeader
        Dim loCls As New PYM08000CLS
        Dim loParam As New PYM08000DTO
        Dim loRtnList As New List(Of PYM08000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getGLHeader(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGLHeader")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGLDetail() As System.ServiceModel.Channels.Message Implements IPYM08000StreamingService.getGLDetail
        Dim loCls As New PYM08000CLS
        Dim loParam As New PYM08000DTO
        Dim loRtnList As New List(Of PYM08000StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cBreakdownBy = R_Utility.R_GetStreamingContext("cBreakdownBy")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cFlag = R_Utility.R_GetStreamingContext("cFlag")
                .cGlGuid = R_Utility.R_GetStreamingContext("cGlGuid")
            End With

            loRtnList = loCls.getGLDetail(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08000StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGLDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYM08000Back.PYM08000UnboundDTO)) Implements IPYM08000StreamingService.Dummy

    End Sub
End Class
