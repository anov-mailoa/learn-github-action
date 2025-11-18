Imports System.ServiceModel.Channels
Imports PNB01100Back
Imports PNB01100Common
Imports R_Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNB01100StreamingService" in code, svc and config file together.
Public Class PNB01100StreamingService
    Implements IPNB01100StreamingService

    Public Function getPnmOrgStructure() As System.ServiceModel.Channels.Message Implements IPNB01100StreamingService.getPnmOrgStructure
        Dim loCls As New PNB01100Cls
        Dim loRtnTemp As List(Of PNB01100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNB01100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            End With

            loRtnTemp = loCls.getPnmOrgStructure(poParam)
            loList = R_Utility.R_GetChunkData(Of PNB01100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPnmOrgStructure")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataDetail() As System.ServiceModel.Channels.Message Implements IPNB01100StreamingService.getDataDetail
        Dim loCls As New PNB01100Cls
        Dim loRtnTemp As List(Of PNB01100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNB01100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cSearchingPosition = R_Utility.R_GetStreamingContext("cSearchingPosition")
                .cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId")
                .cEmployeeKey = R_Utility.R_GetStreamingContext("cEmployeeKey")
                .cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
                .lSearching = R_Utility.R_GetStreamingContext("lSearching")
            End With

            loRtnTemp = loCls.getDataDetail(poParam)
            loList = R_Utility.R_GetChunkData(Of PNB01100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataDetail")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDataHeader() As System.ServiceModel.Channels.Message Implements IPNB01100StreamingService.getDataHeader
        Dim loCls As New PNB01100Cls
        Dim loRtnTemp As List(Of PNB01100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim poParam As New PNB01100DTO
        Dim loEx As New R_Exception

        Try
            With poParam
                .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
                .cUserId = R_Utility.R_GetStreamingContext("cUserId")
                .cKeyGuid = R_Utility.R_GetStreamingContext("cKeyGuid")
            End With

            loRtnTemp = loCls.getDataHeader(poParam)
            loList = R_Utility.R_GetChunkData(Of PNB01100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDataHeader")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getReportData() As System.ServiceModel.Channels.Message Implements IPNB01100StreamingService.getReportData
        Dim loCls As New PNB01100Cls
        Dim loRtnTemp As List(Of PNB01100StreamingDTO)
        Dim loList As List(Of Byte())
        Dim loRtn As Message = Nothing
        Dim loEx As New R_Exception
        Dim loParam As New List(Of PNB01100StreamingDTO)
        Dim loParamObj As String

        Try
            loParamObj = R_Utility.R_GetStreamingContext("oList")

            loParam = R_Utility.XMLToObject(Of List(Of PNB01100StreamingDTO))(loParamObj)

            loRtnTemp = loCls.getReportData(loParam, R_Utility.R_GetStreamingContext("cCompId"), R_Utility.R_GetStreamingContext("cLangId"))
            loList = R_Utility.R_GetChunkData(Of PNB01100StreamingDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportData")

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
