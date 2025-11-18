Imports R_Common
Imports System.ServiceModel.Channels
Imports PYM08100Back
Imports PYM08100Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM08100StreamingService" in code, svc and config file together.
Public Class PYM08100StreamingService
    Implements IPYM08100StreamingService

    Public Function getGLTemplateList() As System.ServiceModel.Channels.Message Implements IPYM08100StreamingService.getGLTemplateList
        Dim loCls As New PYM08100CLS
        Dim loParam As New PYM08100DTO
        Dim loRtnList As New List(Of PYM08100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnList = loCls.getGLTemplateList(loParam)

            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGLTemplateList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGLHeader() As System.ServiceModel.Channels.Message Implements IPYM08100StreamingService.getGLHeader
        Dim loCls As New PYM08100CLS
        Dim loParam As New PYM08100DTO
        Dim loRtnList As New List(Of PYM08100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
            End With

            loRtnList = loCls.getGLHeader(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGLHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGLJournal() As System.ServiceModel.Channels.Message Implements IPYM08100StreamingService.getGLJournal
        Dim loCls As New PYM08100CLS
        Dim loParam As New PYM08100DTO
        Dim loRtnList As New List(Of PYM08100StreamingDTO)
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cTemplateCode = R_Utility.R_GetStreamingContext("cTemplateCode")
                .cHeaderCode = R_Utility.R_GetStreamingContext("cHeaderCode")
                .cEquation = R_Utility.R_GetStreamingContext("cEquation")
            End With

            loRtnList = loCls.getGLJournal(loParam)


            Dim loList As List(Of Byte())
            loList = R_Utility.R_GetChunkData(Of PYM08100StreamingDTO)(loRtnList, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getGLJournal")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParam2 As System.Collections.Generic.List(Of PYM08100Back.PYM08100UnboundDTO)) Implements IPYM08100StreamingService.Dummy

    End Sub
End Class
