Imports R_BackEnd
Imports R_Common
Imports QAR00600Back
Imports QAR00600Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAR00600StreamingService" in code, svc and config file together.
Public Class QAR00600StreamingService
    Implements IQAR00600StreamingService


    Public Function getListTransDepartment() As System.ServiceModel.Channels.Message Implements IQAR00600StreamingService.getListTransDepartment
        Dim loException As New R_Exception
        Dim loCls As New QAR00600CLS
        Dim loRtn As New List(Of QAR00600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR00600DTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")

            loRtn = loCls.getListTransDepartment(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR00600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getListTransDepartment")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getPrintReportTAB1() As System.ServiceModel.Channels.Message Implements IQAR00600StreamingService.getPrintReportTAB1
        Dim loException As New R_Exception
        Dim loCls As New QAR00600CLS
        Dim loRtn As New List(Of QAR00600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR00600DTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cFromDate = R_Utility.R_GetStreamingContext("cFromDate")
            poParam.cToDate = R_Utility.R_GetStreamingContext("cToDate")
            poParam.cStatusList = R_Utility.R_GetStreamingContext("cStatusList")
            poParam.cDeptList = R_Utility.R_GetStreamingContext("cDeptList")


            loRtn = loCls.getPrintReportTAB1(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR00600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getPrintReportTAB1")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function



#Region "Tab 2"

    Public Function getSocializationProcess() As System.ServiceModel.Channels.Message Implements IQAR00600StreamingService.getSocializationProcess
        Dim loException As New R_Exception
        Dim loCls As New QAR00600CLS
        Dim loRtn As New List(Of QAR00600StreamingDTO)
        Dim loRtnMessage As Message
        Dim poParam As New QAR00600DTO
        Dim loList As List(Of Byte())

        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLangId = R_Utility.R_GetStreamingContext("cLangId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cReferenceDateFrom = R_Utility.R_GetStreamingContext("cReferenceDateFrom")
            poParam.cReferenceDateTo = R_Utility.R_GetStreamingContext("cReferenceDateTo")

            loRtn = loCls.getSocializationProcess(poParam)
            loList = R_Utility.R_GetChunkData(Of QAR00600StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)
            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getSocializationProcess")

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

#Region "Report"
    Public Function getReportSocializationInfo() As System.ServiceModel.Channels.Message Implements IQAR00600StreamingService.getReportSocializationInfo
        Dim loException As New R_Exception
        Dim loCls As New QAR00600CLS
        Dim loRtnTemp As List(Of RSP_QAR00600_SOCIALIZATIONDTO)
        Dim loParam As New QAR00600DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())

        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cListGrid = R_Utility.R_GetStreamingContext("cListGrid")
        End With

        Try
            loRtnTemp = loCls.getReportSocializationInfo(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00600_SOCIALIZATIONDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportSocializationInfo")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    Public Function getReportSocializationDocument() As System.ServiceModel.Channels.Message Implements IQAR00600StreamingService.getReportSocializationDocument
        Dim loException As New R_Exception
        Dim loCls As New QAR00600CLS
        Dim loRtnTemp As List(Of RSP_QAR00600_SOCDOCUMENTDTO)
        Dim loParam As New QAR00600DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cListGrid = R_Utility.R_GetStreamingContext("cListGrid")
        End With

        Try
            loRtnTemp = loCls.getReportSocializationDocument(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00600_SOCDOCUMENTDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportSocializationDocument")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getReportSocializationAttachment() As System.ServiceModel.Channels.Message Implements IQAR00600StreamingService.getReportSocializationAttachment
        Dim loException As New R_Exception
        Dim loCls As New QAR00600CLS
        Dim loRtnTemp As List(Of RSP_QAR00600_SOCATTACHMENTDTO)
        Dim loParam As New QAR00600DTO
        Dim loRtn As Message
        Dim loList As List(Of Byte())
        With loParam
            .cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            .cLangId = R_Utility.R_GetStreamingContext("cLangId")
            .cListGrid = R_Utility.R_GetStreamingContext("cListGrid")
        End With

        Try
            loRtnTemp = loCls.getReportSocializationAttachment(loParam)
            loList = R_Utility.R_GetChunkData(Of RSP_QAR00600_SOCATTACHMENTDTO)(loRtnTemp, R_BackGlobalVar.CHUNK_SIZE)
            loRtn = R_StreamUtility(Of Byte()).WriteToMessage(loList.AsEnumerable, "getReportSocializationAttachment")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


#End Region
#End Region



    Public Sub Dummy(poPar2 As QAR00600Back.QAR00600ReportDTO) Implements IQAR00600StreamingService.Dummy

    End Sub
End Class
