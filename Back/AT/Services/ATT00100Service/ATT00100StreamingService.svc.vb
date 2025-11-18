Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00100Back
Imports att00100common
Imports System.ServiceModel.Channels ' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00100StreamingService" in code, svc and config file together.
Public Class ATT00100StreamingService
    Implements IATT00100StreamingService
     
    Public Function getOvertime() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getOvertime
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcUserId, pcLangId As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcUserId = R_Utility.R_GetStreamingContext("cUserId")
            pcLangId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getOvertime(pcCompId, pcUserId, pcLangId)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getOvertime")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getShift() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getShift
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00100DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cShiftDate = R_Utility.R_GetStreamingContext("cShiftDt")
            loRtn = loCls.getShift(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getShift")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getHistory
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00100DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageid")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cReferencePeriod = R_Utility.R_GetStreamingContext("cReferencePeriod")
            loRtn = loCls.getHistory(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getEmployee
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00100DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            poParam.cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
            loRtn = loCls.getEmployee(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getFacility() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getFacility
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00100DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode")
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo")
            loRtn = loCls.getFacility(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getFacility")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getSchedule() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getSchedule
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim pcCompId, pcShiftDt, pcShiftCd As String
        Dim loChunk As New List(Of Byte())


        Try

            pcCompId = R_Utility.R_GetStreamingContext("cCompanyId")
            pcShiftDt = R_Utility.R_GetStreamingContext("cShiftDt")
            'pcShiftCd = R_Utility.R_GetStreamingContext("cShiftCode")
            loRtn = loCls.getSchedule(pcCompId, pcShiftDt, pcShiftCd)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getSchedule")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getPopUpEmployee() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getPopUpEmployee
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00100DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.iTransactionType = R_Utility.R_GetStreamingContext("iTransactionType")
            poParam.cShiftCode = R_Utility.R_GetStreamingContext("cShiftCode")
            poParam.cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate")
            poParam.CPROG = R_Utility.R_GetStreamingContext("CPROG")
            poParam.iPaidType = R_Utility.R_GetStreamingContext("iPaidType")
            poParam.iDayType = R_Utility.R_GetStreamingContext("iDayType")
            loRtn = loCls.getPopUpEmployee(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getPopUpEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
     
    Public Function getCmbIndex() As System.ServiceModel.Channels.Message Implements IATT00100StreamingService.getCmbIndex
        Dim loRtn As New List(Of ATT00100StreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATT00100Cls
        Dim loEx As New R_Exception
        Dim poParam As New ATT00100DTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId") 
            loRtn = loCls.getCmbIndex(poParam)
            loChunk = R_Utility.R_GetChunkData(Of ATT00100StreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getCmbIndex")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
