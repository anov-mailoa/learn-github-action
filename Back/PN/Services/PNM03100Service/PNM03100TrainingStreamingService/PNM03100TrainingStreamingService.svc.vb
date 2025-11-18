' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM03100TrainingStreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports PNM03100Common
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class PNM03100TrainingStreamingService
    Implements IPNM03100TrainingStreamingService

    Public Function getTraining() As System.ServiceModel.Channels.Message Implements IPNM03100TrainingStreamingService.getTraining
        Dim loRtnTemp As List(Of PNM03100TrainingStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100TrainingCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100TrainingDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")

            loRtnTemp = loCls.getTraining(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100TrainingStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getTraining")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getlReqRecurring() As System.ServiceModel.Channels.Message Implements IPNM03100TrainingStreamingService.getlReqRecurring
        Dim loRtnTemp As List(Of PNM03100TrainingStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100TrainingCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100TrainingDTO

        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCatTrainingCode = R_Utility.R_GetStreamingContext("cCatTrainingCode")
            poParam.cTrainingCode = R_Utility.R_GetStreamingContext("cTrainingCode")

            loRtnTemp = loCls.getlReqRecurring(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100TrainingStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getlReqRecurring")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class
