Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00500StreamService" in code, svc and config file together.
Public Class ATT00500StreamService
    Implements IATT00500StreamService

    Public Function getTransactionList() As System.ServiceModel.Channels.Message Implements IATT00500StreamService.getTransactionList
        Dim loRtn As Message
        Dim loCls As New ATT00500TransactionCLS
        Dim loEx As New R_Exception
        Dim lcStreamReturn As New List(Of ATT00500TransactionStreamDTO)
        Try
            'Dim cCompanyId As String = R_Utility.R_GetStreamingContext("cCompanyId").ToString
            'Dim cDateNow As String = R_Utility.R_GetStreamingContext("dDate").ToString
            'Dim cGroupCode As String = R_Utility.R_GetStreamingContext("cGroupCode").ToString
            'Dim cLoginId As String = R_Utility.R_GetStreamingContext("cLoginId").ToString

            Dim poParam As New ATT00500TransactionDTO

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId").ToString
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId").ToString
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode").ToString
            poParam.cLanguage = R_Utility.R_GetStreamingContext("cLanguage").ToString

            lcStreamReturn = loCls.getTransactionList(poParam)
            loRtn = R_StreamUtility(Of ATT00500TransactionStreamDTO).WriteToMessage(lcStreamReturn.AsEnumerable, "StreamTransactionList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEmployeeList() As System.ServiceModel.Channels.Message Implements IATT00500StreamService.getEmployeeList
        Dim loRtn As Message
        Dim loCls As New ATT00500EmployeeCLS
        Dim loEx As New R_Exception
        Dim lcStreamReturn As New List(Of ATT00500EmployeeStreamDTO)
        Try
            Dim poParam As New ATT00500EmployeeDTO

            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId").ToString
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode").ToString
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode").ToString
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo").ToString
            poParam.cUserId = R_Utility.R_GetStreamingContext("cUserId").ToString
            poParam.cEmployeeId = R_Utility.R_GetStreamingContext("cEmployeeId").ToString
            poParam.lIncludeAllLevelBelow = R_Utility.R_GetStreamingContext("lIncludeAllLevelBelow").ToString
            poParam.cShiftDate = R_Utility.R_GetStreamingContext("cShiftDate").ToString
            poParam.cPositionCode = R_Utility.R_GetStreamingContext("cPositionCode").ToString
            lcStreamReturn = loCls.getEmployeeList(poParam)
            loRtn = R_StreamUtility(Of ATT00500EmployeeStreamDTO).WriteToMessage(lcStreamReturn.AsEnumerable, "StreamEmployeeList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getListFacility() As System.ServiceModel.Channels.Message Implements IATT00500StreamService.getListFacility
        Dim loRtn As Message
        Dim loCls As New ATT00500FacilityCLS
        Dim loEx As New R_Exception
        Dim lcStreamReturn As New List(Of ATT00500FacilityStreamDTO)
        Try
            Dim poParam As New ATT00500FacilityDTO
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId").ToString
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode").ToString
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode").ToString
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo").ToString
            lcStreamReturn = loCls.getListFacility(poParam)
            loRtn = R_StreamUtility(Of ATT00500FacilityStreamDTO).WriteToMessage(lcStreamReturn.AsEnumerable, "StreamFacilityList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMultipleEmployeeList() As System.ServiceModel.Channels.Message Implements IATT00500StreamService.getMultipleEmployeeList
        Dim loRtn As Message
        Dim loCls As New ATT00501CLS
        Dim loEx As New R_Exception
        Dim lcStreamReturn As New List(Of ATT00500EmployeeStreamDTO)
        Try
            Dim poParam As New ATT00500EmployeeDTO
            poParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId").ToString
            poParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode").ToString
            poParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode").ToString
            poParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo").ToString

            lcStreamReturn = loCls.getAddMultipleEmployeeList(poParam)
            loRtn = R_StreamUtility(Of ATT00500EmployeeStreamDTO).WriteToMessage(lcStreamReturn.AsEnumerable, "StreamMultipleList")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getHistory() As System.ServiceModel.Channels.Message Implements IATT00500StreamService.getHistory
        Dim lcStreamReturn As List(Of ATT00510StreamingDTO)
        Dim loCls As New ATT00510CLS
        Dim loParam As New ATT00510RegulerDTO
        Dim loEx As New R_Exception
        Dim loRtn As Message

        Try
            loParam.cCompanyId = R_Utility.R_GetStreamingContext("cCompanyId").ToString
            loParam.cUserId = R_Utility.R_GetStreamingContext("cUserId").ToString
            loParam.cLanguage = R_Utility.R_GetStreamingContext("cLanguage").ToString
            loParam.cTransactionCode = R_Utility.R_GetStreamingContext("cTransactionCode").ToString
            loParam.cShiftPeriod = R_Utility.R_GetStreamingContext("cShiftPeriod").ToString
            loParam.cClosed = R_Utility.R_GetStreamingContext("cClosed").ToString
            loParam.cCanceled = R_Utility.R_GetStreamingContext("cCanceled").ToString
            loParam.cDeleted = R_Utility.R_GetStreamingContext("cDeleted").ToString

            'loParam.cDeptCode = R_Utility.R_GetStreamingContext("cDeptCode").ToString
            'loParam.cReferenceNo = R_Utility.R_GetStreamingContext("cReferenceNo").ToString
            'loParam.cTransactionStatus = R_Utility.R_GetStreamingContext("cTransactionStatus").ToString

            lcStreamReturn = loCls.getHistory(loParam)

            loRtn = R_StreamUtility(Of ATT00510StreamingDTO).WriteToMessage(lcStreamReturn.AsEnumerable, "getHistory")
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Dummy(poParStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500TransactionStreamDTO), poParEmployeeStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500EmployeeStreamDTO), poParFacilityStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500FacilityStreamDTO), poHeaderGrid As System.Collections.Generic.List(Of ATT00500Back.ATT00500HeaderGridDTO), poParShiftInformationStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500ShiftInformationStreamDTO), poParHistoryStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00510StreamingDTO), poParHistoryRegular As ATT00500Back.ATT00510RegulerDTO) Implements IATT00500StreamService.Dummy

    End Sub
End Class
