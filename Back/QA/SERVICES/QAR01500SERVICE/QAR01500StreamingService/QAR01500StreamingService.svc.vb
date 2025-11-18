Imports R_BackEnd
Imports R_Common
Imports QAR01500Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports QAR01500Common

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR01500StreamingService" in code, svc and config file together.
Public Class QAR01500StreamingService
    Implements IQAR01500StreamingService

    Public Function getListDocOwner() As System.ServiceModel.Channels.Message Implements IQAR01500StreamingService.getListDocOwner
        Dim loException As New R_Exception
        Dim loCls As New QAR01500CLS
        Dim loRtn As New List(Of QAR01500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01500DTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")


            loRtn = loCls.getListDocOwner(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(lolist.AsEnumerable, "getListDocOwner")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getComboDeptList() As System.ServiceModel.Channels.Message Implements IQAR01500StreamingService.getComboDeptList
        Dim loException As New R_Exception
        Dim loCls As New QAR01500CLS
        Dim loRtn As New List(Of QAR01500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01500DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getComboDeptList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getComboDeptList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getDocList() As System.ServiceModel.Channels.Message Implements IQAR01500StreamingService.getDocList
        Dim loException As New R_Exception
        Dim loCls As New QAR01500CLS
        Dim loRtn As New List(Of QAR01500StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01500DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cDocOwner = R_Utility.R_GetStreamingContext("cDocOwner")
            poParam.lDocStatus = R_Utility.R_GetStreamingContext("lDocStatus")

            loRtn = loCls.getDocList(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01500StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getDocList")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function


    Public Function getPrintReportTAB1() As System.ServiceModel.Channels.Message Implements IQAR01500StreamingService.getPrintReportTAB1
        Dim loException As New R_Exception
        Dim loCls As New QAR01500CLS
        Dim loRtn As New List(Of QAR01500ReportDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01500DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cDocOwnerList = R_Utility.R_GetStreamingContext("cDocOwnerList")
            poParam.lIncludeObseletedoc = R_Utility.R_GetStreamingContext("lIncludeObseletedoc")
            poParam.lFilterByeFfdate = R_Utility.R_GetStreamingContext("lFilterByeFfdate")
            poParam.cEffDateFrom = R_Utility.R_GetStreamingContext("cEffDateFrom")
            poParam.cEffDateTo = R_Utility.R_GetStreamingContext("cEffDateTo")


            loRtn = loCls.getPrintReportTAB1(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01500ReportDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPrintReportTAB1")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPrintReportTAB2() As System.ServiceModel.Channels.Message Implements IQAR01500StreamingService.getPrintReportTAB2
        Dim loException As New R_Exception
        Dim loCls As New QAR01500CLS
        Dim loRtn As New List(Of QAR01500ReportDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR01500DTO
        Dim loList As List(Of Byte())
        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptOwner = R_Utility.R_GetStreamingContext("cDeptOwner")
            poParam.lDocnoCheckdall = R_Utility.R_GetStreamingContext("lDocnoCheckdall")
            poParam.cDocOwnerList = R_Utility.R_GetStreamingContext("cDocOwnerList")

            loRtn = loCls.getPrintReportTAB2(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR01500ReportDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPrintReportTAB2")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
