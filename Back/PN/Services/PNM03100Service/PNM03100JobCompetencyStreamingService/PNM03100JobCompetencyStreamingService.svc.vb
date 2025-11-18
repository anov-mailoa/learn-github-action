' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM03100JobCompetencyStreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports PNM03100Common
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class PNM03100JobCompetencyStreamingService
    Implements IPNM03100JobCompetencyStreamingService

    Public Function getCategoryCompetency() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getCategoryCompetency
        Dim loRtnTemp As List(Of PNM03100JobCompetencyHeaderStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobCompetencyCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100JobCompetencyDTO


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")

            loRtnTemp = loCls.getCategoryCompetency(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100JobCompetencyHeaderStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCategoryCompetency")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbBenchmark() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getCmbBenchmark
        Dim loRtnTemp As List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobCompetencyCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100ComboDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
            End With

            loRtnTemp = loCls.getCmbBenchmark(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbBenchmark")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCatCompetency() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getCmbCatCompetency
        Dim loRtnTemp As List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobCompetencyCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100ComboDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getCmbCatCompetency(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCatCompetency")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbCompetency() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getCmbCompetency
        Dim loRtnTemp As List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobCompetencyCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100ComboDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")

            loRtnTemp = loCls.getCmbCompetency(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCompetency")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbTrainingCategory() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getCmbTrainingCategory
        Dim loRtnTemp As List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobCompetencyCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100ComboDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")

            loRtnTemp = loCls.getCmbTrainingCategory(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbTrainingCategory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbTrainingSubject() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getCmbTrainingSubject
        Dim loRtnTemp As List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobCompetencyCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100ComboDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCatTrainingCode = R_Utility.R_GetStreamingContext("cCatTrainingCode")

            loRtnTemp = loCls.getCmbTrainingSubject(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbTrainingSubject")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getRelatedTraining() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getRelatedTraining
        Dim loRtnTemp As List(Of PNM03100JobCompetencyDetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100RelatedTrainingCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100JobCompetencyDetailDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
            End With

            loRtnTemp = loCls.getRelatedTraining(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100JobCompetencyDetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getRelatedTraining")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParPNM03100Streaming As System.Collections.Generic.List(Of PNM03100Back.PNM03100JobCompetencyHeaderDTO)) Implements IPNM03100JobCompetencyStreamingService.Dummy

    End Sub

    Public Function getScoringInfoList() As System.ServiceModel.Channels.Message Implements IPNM03100JobCompetencyStreamingService.getScoringInfoList
        Dim loRtnTemp As List(Of PNM03100JobCompetencyDetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100ScoringInfoCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100JobCompetencyDTO

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
                .cCatCompetencyCode = R_Utility.R_GetStreamingContext("cCatCompetencyCode")
                .cCompetencyCode = R_Utility.R_GetStreamingContext("cCompetencyCode")
                .cLangId = R_Utility.R_GetStreamingContext("cLangId")
                .LAPPLY_TO_ALL_POSITION = R_Utility.R_GetStreamingContext("LAPPLY_TO_ALL_POSITION")
            End With

            loRtnTemp = loCls.getScoringInfoList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100JobCompetencyDetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getScoringInfoList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
