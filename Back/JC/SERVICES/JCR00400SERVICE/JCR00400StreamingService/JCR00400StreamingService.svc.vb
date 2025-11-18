' NOTE: You can use the "Rename" command on the context menu to change the class name "JCR00400StreamingService" in code, svc and config file together.
Imports R_Common
Imports R_BackEnd
Imports JCR00400Back
Imports System.ServiceModel.Channels
Imports JCR00400Common

Public Class JCR00400StreamingService
    Implements IJCR00400StreamingService

    Public Function getData() As System.ServiceModel.Channels.Message Implements IJCR00400StreamingService.getData
        Dim loEx As New R_Exception
        Dim loCls As New JCR00400CLS
        Dim loRtnTemp As List(Of JCR00400StreamingDTO)
        Dim loRtn As Message
        Dim loParam As New JCR00400DTO
        Dim loList As List(Of Byte())
        Try
            With loParam

                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionList = R_Utility.R_GetStreamingContext("cPositionList")
                .lIncludeallLevel = R_Utility.R_GetStreamingContext("lIncludeAllLevel")
                .cCompetencyFilterBy = R_Utility.R_GetStreamingContext("cCompetencyFilterBy")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
                .cCategoryCode = R_Utility.R_GetStreamingContext("cCategoryCode")
                .lIncludeApplicable = R_Utility.R_GetStreamingContext("lIncludeApplicable")
                .cEvaluationFilterBy = R_Utility.R_GetStreamingContext("cEvaluationFilterBy")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With
            loRtnTemp = loCls.getData(loParam)
            loList = R_Utility.R_GetChunkData(Of JCR00400StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of JCR00400Back.JCR00400DTO), poParTenorReport As System.Collections.Generic.List(Of JCR00400Back.JCR00400ReportHeaderDTO)) Implements IJCR00400StreamingService.Dummy

    End Sub

    Public Function GetDataCompetency() As System.ServiceModel.Channels.Message Implements IJCR00400StreamingService.GetDataCompetency
        Dim loRtn As New List(Of JCR00400StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00400CLS
        Dim loEx As New R_Exception
        Dim poParam As New JCR00400DTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.GetDataCompetency(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00400StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDataCompetency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function
End Class
