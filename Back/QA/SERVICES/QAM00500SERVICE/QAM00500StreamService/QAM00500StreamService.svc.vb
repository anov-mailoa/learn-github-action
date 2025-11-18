Imports R_Common
Imports QAM00500Back
Imports System.ServiceModel.Channels
Imports QAM00500Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAM00500StreamService" in code, svc and config file together.
Public Class QAM00500StreamService
    Implements IQAM00500StreamService


    Public Function GetClauseList() As System.ServiceModel.Channels.Message Implements IQAM00500StreamService.GetClauseList
        Dim loException As New R_Exception
        Dim loCls As New QAM00500ClauseCls
        Dim loRtnTemp As List(Of QAM00500StreamDto)
        Dim loParam As New QAM00500Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cIsoType = R_Utility.R_GetStreamingContext("cIsoType")
            .cIsoVersion = R_Utility.R_GetStreamingContext("cIsoVersion")
        End With

        Try
            loRtnTemp = loCls.GetClauseList(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00500StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)

            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetClauseList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetIsoTypeList() As System.ServiceModel.Channels.Message Implements IQAM00500StreamService.GetIsoTypeList
        Dim loException As New R_Exception
        Dim loCls As New QAM00500IsoTypeCls
        Dim loRtnTemp As List(Of QAM00500StreamDto)
        Dim loParam As New QAM00500Dto
        Dim loRtn As Message
        Dim loChunk As New List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
        End With

        Try
            loRtnTemp = loCls.GetIsoTypeList(loParam)

            loChunk = R_Utility.R_GetChunkData(Of QAM00500StreamDto)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "GetIsoTypeList")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poGrid As QAM00500Back.QAM00500GridDto) Implements IQAM00500StreamService.Dummy

    End Sub
End Class
