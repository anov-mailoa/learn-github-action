' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM03100JobSpecStreamingService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports PNM03100Common
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO

Public Class PNM03100JobSpecStreamingService
    Implements IPNM03100JobSpecStreamingService

    Public Function getCmbCategory() As System.ServiceModel.Channels.Message Implements IPNM03100JobSpecStreamingService.getCmbCategory
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNM03100JobSpecCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try

            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getCmbCategory(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbCategory")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getCmbCriteria() As System.ServiceModel.Channels.Message Implements IPNM03100JobSpecStreamingService.getCmbCriteria
        Dim loRtnTemp As List(Of PNM03100ComboDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobSpecCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try

            loRtnTemp = loCls.getCmbCriteria(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100ComboDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCriteria")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getCmbSingleValue() As System.ServiceModel.Channels.Message Implements IPNM03100JobSpecStreamingService.getCmbSingleValue
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNM03100JobSpecCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getCmbSingleValue(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbSingleValue")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getJobSpecDt() As System.ServiceModel.Channels.Message Implements IPNM03100JobSpecStreamingService.getJobSpecDt
        Dim loRtnTemp As List(Of PNM03100JobSpecDetailStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobSpecCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100JobSpecDTO

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cCategoryId = R_Utility.R_GetStreamingContext("cCategoryId")
            poParam.cCriteriaId = R_Utility.R_GetStreamingContext("cCriteriaId")
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")

            loRtnTemp = loCls.getJobSpecDt(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100JobSpecDetailStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getJobSpecDt")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getJobSpecHd() As System.ServiceModel.Channels.Message Implements IPNM03100JobSpecStreamingService.getJobSpecHd
        Dim loRtnTemp As List(Of PNM03100JobSpecHeaderStreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loCls As New PNM03100JobSpecCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100JobSpecDTO

        Try

            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode")
            End With

            loRtnTemp = loCls.getJobSpecHd(poParam)
            loList = R_Utility.R_GetChunkData(Of PNM03100JobSpecHeaderStreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getJobSpecHd")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbSpecType() As System.ServiceModel.Channels.Message Implements IPNM03100JobSpecStreamingService.getCmbSpecType
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loRtnMessage As Message = Nothing
        Dim loCls As New PNM03100JobSpecCLS
        Dim loEx As New R_Exception
        Dim poParam As New PNM03100DTO

        Try

            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")

            loRtn = loCls.getCmbSpecType(poParam)
            loRtnMessage = R_StreamUtility(Of LookUpCmbDTO).WriteToMessage(loRtn.AsEnumerable, "getCmbSpecType")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Sub Dummy(poParPNM03100Streaming As System.Collections.Generic.List(Of PNM03100Back.PNM03100JobSpecHeaderDTO)) Implements IPNM03100JobSpecStreamingService.Dummy

    End Sub

End Class
