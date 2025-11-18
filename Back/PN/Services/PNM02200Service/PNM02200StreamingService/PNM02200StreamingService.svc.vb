' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02200SteramingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back
Imports PNM02200Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class PNM02200StreamingService
    Implements IPNM02200StreamingService

    Public Function getCompetencyCategories() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getCompetencyCategories
        Dim loRtnTemp As List(Of PNM02200HeaderStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM02200CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM02200HeaderDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getCompetencyCategories(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02200HeaderStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "CompetencyCategories")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCompetencyInfo() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getCompetencyInfo
        Dim loRtnTemp As List(Of PNM02200DetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM02200DetailCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM02200DetailDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")

            loRtnTemp = loCls.getCompetencyInfo(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02200DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "CompetencyInfo")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDefaultBenchmark() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getDefaultBenchmark
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNM02200CLS
        Dim loEx As New R_Exception
        Dim loParam As New PNM02200HeaderDTO

        Try
            With loParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cScoreGroup = R_Utility.R_GetStreamingContext("cScoreGroup")
            End With
            loRtn = loCls.getDefaultBenchmark(loParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "DefaultBenchmark")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getScore() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getScore
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNM02200CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM02200FormDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtn = loCls.getScore(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "Score")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getCmbActive() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getCmbActive
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNM02200CLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM02200HeaderDTO

        Try
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getCmbActive(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbActive")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getReport() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getReport
        Dim loCls As New PNM02200CLS
        Dim loRtnTemp As List(Of PNM02200ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNM02200HeaderDTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getReportData(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02200ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReport")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParamDetail As System.Collections.Generic.List(Of PNM02200Back.PNM02200DetailDTO)) Implements IPNM02200StreamingService.Dummy

    End Sub

    Public Function getRelatedTraining() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getRelatedTraining
        Dim loRtnTemp As List(Of PNM02200DetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM02200RelatedTrainingCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM02200RelatedTrainingDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
            End With

            loRtnTemp = loCls.getRelatedTraining(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02200DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRelatedTraining")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getMultipleTraining() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getMultipleTraining
        Dim loRtnTemp As List(Of PNM02200DetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM02200RelatedTrainingCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM02200RelatedTrainingDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.getMultipleTraining(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02200DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getMultipleTraining")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCompetencyScoreList() As System.ServiceModel.Channels.Message Implements IPNM02200StreamingService.getCompetencyScoreList
        Dim loRtnTemp As List(Of PNM02200DetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM02200CompetencyScoreCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM02200DetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
                .CSCORE_GROUP = R_Utility.R_GetStreamingContext("CSCORE_GROUP")
                .CLANG_ID = R_Utility.R_GetStreamingContext("CLANG_ID")
            End With

            loRtnTemp = loCls.getCompetencyScoreList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM02200DetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCompetencyScoreList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
