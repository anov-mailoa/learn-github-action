Imports R_Common
Imports R_BackEnd
Imports JCR00200Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports JCR00200Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCR00200StreamingService" in code, svc and config file together.
Public Class JCR00200StreamingService
    Implements IJCR00200StreamingService


    Public Function getReport() As System.ServiceModel.Channels.Message Implements IJCR00200StreamingService.getReport
        Dim loRtn As New List(Of JCR00200StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00200CLS
        Dim loEx As New R_Exception
        Dim poParam As New JCR00200DTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            poParam.cCompetencyCode = R_Utility.R_GetStreamingContext("gcCompetencyList")
            poParam.cEvaluationType = R_Utility.R_GetStreamingContext("cEvaluationType")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.lIncludeApplicable = R_Utility.R_GetStreamingContext("chkIncNotAppCom")
            poParam.liFilterDate = R_Utility.R_GetStreamingContext("cFilterDate")
            poParam.cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
            poParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")
            poParam.cEncKey = R_Utility.R_GetStreamingContext("cEncryptKey")

            loRtn = loCls.getReport(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Sub Dummy(poParTenor As System.Collections.Generic.List(Of JCR00200Back.JCR00200DTO)) Implements IJCR00200StreamingService.Dummy

    End Sub

    Public Function GetDataGrid() As System.ServiceModel.Channels.Message Implements IJCR00200StreamingService.GetDataGrid
        Dim loRtn As New List(Of JCR00200StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00200CLS
        Dim loEx As New R_Exception
        Dim poParam As New JCR00200DTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
            poParam.cEvaluationType = R_Utility.R_GetStreamingContext("cEvaluationType")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            poParam.lIncludeLvlBelow = R_Utility.R_GetStreamingContext("lIncludeLvlBelow")

            loRtn = loCls.GetDataGrid(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDataGrid")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function

    Public Function GetDataCompetency() As System.ServiceModel.Channels.Message Implements IJCR00200StreamingService.GetDataCompetency
        Dim loRtn As New List(Of JCR00200StreamingDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New JCR00200CLS
        Dim loEx As New R_Exception
        Dim poParam As New JCR00200DTO
        Dim loList As List(Of Byte())

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")
            poParam.lisAllCompetency = R_Utility.R_GetStreamingContext("lisAllCompetency")

            loRtn = loCls.GetDataCompetency(poParam)
            loList = R_Utility.R_GetChunkData(Of JCR00200StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetDataCompetency")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtnMessage
    End Function
End Class
