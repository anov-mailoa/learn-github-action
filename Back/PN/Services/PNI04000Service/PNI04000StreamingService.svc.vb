Imports System.ServiceModel.Channels
Imports PNI04000Back
Imports PNI04000Common
Imports R_Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNI04000StreamingService" in code, svc and config file together.
Public Class PNI04000StreamingService
    Implements IPNI04000StreamingService

    Public Function getCmbCriteria() As System.ServiceModel.Channels.Message Implements IPNI04000StreamingService.getCmbCriteria
        Dim loCls As New PNI04000CLS
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI04000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try

            loRtnTemp = loCls.getCmbCriteria()
            loList = R_Utility.R_GetChunkData(Of PNI04000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCmbCriteria")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCriteriaSelectedValue() As System.ServiceModel.Channels.Message Implements IPNI04000StreamingService.getCriteriaSelectedValue
        Dim loCls As New PNI04000CLS
        Dim poParam As New PNI04000DTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI04000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCriteriaId = R_Utility.R_GetStreamingContext("cCriteriaId")
            End With

            loRtnTemp = loCls.getCriteriaSelectedValue(poParam)
            loList = R_Utility.R_GetChunkData(Of PNI04000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getCriteriaSelectedValue")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNI04000StreamingService.getReportData
        Dim loCls As New PNI04000CLS
        Dim loEx As New R_Exception

        Dim loParamCriteria As New List(Of PNI04000StreamingDTO)
        Dim loParamValue As New List(Of PNI04000StreamingDTO)
        Dim lcParamCriteria As String
        Dim lcParamValue As String

        Dim loRtnTemp As New List(Of PNI04000ReportDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing


        Try

            lcParamCriteria = R_Utility.R_GetStreamingContext("oListCriteria")
            lcParamValue = R_Utility.R_GetStreamingContext("oListValue")

            loParamCriteria = R_Utility.XMLToObject(Of List(Of PNI04000StreamingDTO))(lcParamCriteria)
            loParamValue = R_Utility.XMLToObject(Of List(Of PNI04000StreamingDTO))(lcParamValue)

            loRtnTemp = loCls.getReportData(loParamCriteria, loParamValue)
            loList = R_Utility.R_GetChunkData(Of PNI04000ReportDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCriteriaList() As System.ServiceModel.Channels.Message Implements IPNI04000StreamingService.GetCriteriaList
        Dim loCls As New PNI04000CLS
        Dim poParam As New PNI04000DTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI04000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            End With

            loRtnTemp = loCls.GetCriteriaList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNI04000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCriteriaList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetCategoryList() As System.ServiceModel.Channels.Message Implements IPNI04000StreamingService.GetCategoryList
        Dim loCls As New PNI04000CLS
        Dim poParam As New PNI04000DTO
        Dim loEx As New R_Exception
        Dim loRtnTemp As List(Of PNI04000StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cCriteriaGuid = R_Utility.R_GetStreamingContext("cCriteriaGuid")
            End With

            loRtnTemp = loCls.GetCategoryList(poParam)
            loList = R_Utility.R_GetChunkData(Of PNI04000StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "GetCategoryList")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
