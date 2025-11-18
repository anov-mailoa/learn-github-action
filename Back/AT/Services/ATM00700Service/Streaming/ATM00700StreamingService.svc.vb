Imports R_BackEnd
Imports R_Common
Imports ATM00700Back
Imports ATM00700Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd.R_BackGlobalVar
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATM00700StreamingService" in code, svc and config file together.
Public Class ATM00700StreamingService
    Implements IATM00700StreamingService

    Public Function getLeaveManagement() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getLeaveManagement
        Dim loRtn As New List(Of ATM00700LeaveManagementStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700LeaveManagementCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700LeaveManagementDTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
            loRtn = loCls.getLeaveManagement(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ATM00700LeaveManagementStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getLeaveManagement")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getMultiRange() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getMultiRange
        Dim loRtn As New List(Of ATM00700MultiRangeStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700MultiRangeCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700MultiRangeDTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLeaveType = R_Utility.R_GetStreamingContext("cLeaveType")
            poParam.cLeaveCode = R_Utility.R_GetStreamingContext("cLeaveCode")
            loRtn = loCls.getMultiRange(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ATM00700MultiRangeStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getMultiRange")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getAnnualLeave() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getAnnualLeave
        Dim loRtn As New List(Of ATM00700AnnualStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700AnnualLeaveCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700AnnualLeaveDTO
        Dim loChunk As New List(Of Byte())


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getAnnualLeave(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ATM00700AnnualStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getAnnualLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getDispensationLeave() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getDispensationLeave
        Dim loRtn As New List(Of ATM00700DispensationStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700DispensationLeaveCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700DispensationDTO
        Dim loChunk As New List(Of Byte())


        Try
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getDispensationLeave(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ATM00700DispensationStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getDispensationLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getSpecialLeave() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getSpecialLeave
        Dim loRtn As New List(Of ATM00700AnnualStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700AnnualLeaveCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700AnnualLeaveDTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            loRtn = loCls.getSpecialLeave(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ATM00700AnnualStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getSpecialLeave")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage

    End Function

    Public Function getEmployee() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getEmployee
        Dim loRtn As New List(Of ATM00700EmployeeStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700EmployeeCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700EmployeeStreamingDTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            poParam.cLeavecode = R_Utility.R_GetStreamingContext("cLeaveCode")
            loRtn = loCls.getEmployee(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ATM00700EmployeeStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getEmployee")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListCategory() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getListCategory
        Dim loRtn As New List(Of ComboBoxDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700RulesCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700RulesDTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cLanguageId = R_Utility.R_GetStreamingContext("cLanguageId")
            loRtn = loCls.getListCategory(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ComboBoxDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListCategory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function

    Public Function getListRules() As System.ServiceModel.Channels.Message Implements IATM00700StreamingService.getListRules
        Dim loRtn As New List(Of ATM00700RulesStreamingDTO)
        Dim loRtnMessage As Message
        Dim loCls As New ATM00700RulesCls
        Dim loEx As New R_Exception
        Dim poParam As New ATM00700RulesDTO
        Dim loChunk As New List(Of Byte())


        Try

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId")
            poParam.cAdditionalLeaveCode = R_Utility.R_GetStreamingContext("cAdditionalLeaveCode")

            loRtn = loCls.getListRules(poParam)

            loChunk = R_Utility.R_GetChunkData(Of ATM00700RulesStreamingDTO)(loRtn, R_BackGlobalVar.CHUNK_SIZE)

            loRtnMessage = R_StreamUtility(Of Byte()).WriteToMessage(loChunk.AsEnumerable, "getListRules")
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtnMessage
    End Function
End Class
