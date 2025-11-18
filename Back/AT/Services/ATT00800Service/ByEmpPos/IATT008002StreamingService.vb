Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT008002StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT008002StreamingService

    <OperationContract(Action:="getAttCorrectionByPosition", ReplyAction:="getAttCorrectionByPosition")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getAttCorrectionByPosition() As Message

    <OperationContract(Action:="getAttCorrectionByEmp", ReplyAction:="getAttCorrectionByEmp")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getAttCorrectionByEmp() As Message

    <OperationContract(Action:="getDepartment", ReplyAction:="getDepartment")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getDepartment() As Message

    <OperationContract(Action:="getShiftCode", ReplyAction:="getShiftCode")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getShiftCode() As Message

    <OperationContract(Action:="getLookUpTime", ReplyAction:="getLookUpTime")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getLookUpTime() As Message

    <OperationContract(Action:="RFT_AT_CALCULATE_CUT_OFF", ReplyAction:="RFT_AT_CALCULATE_CUT_OFF")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function RFT_AT_CALCULATE_CUT_OFF() As Message

    <OperationContract(Action:="RFT_AT_CALCULATE_CUT_OFF_LIST", ReplyAction:="RFT_AT_CALCULATE_CUT_OFF_LIST")>
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_AT_CALCULATE_CUT_OFF_LIST() As Message

    <OperationContract(Action:="getLookUpWorkGroup", ReplyAction:="getLookUpWorkGroup")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getLookUpWorkGroup() As Message

    <OperationContract(Action:="getLookUpReason", ReplyAction:="getLookUpReason")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getLookUpReason() As Message


    <OperationContract(Action:="getEmpByReason", ReplyAction:="getEmpByReason")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getEmpByReason() As Message

    <OperationContract(Action:="getSchedule", ReplyAction:="getSchedule")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getSchedule() As Message

    <OperationContract(Action:="RSP_AT_VALIDATE_SHIFT_CORRECTION", ReplyAction:="RSP_AT_VALIDATE_SHIFT_CORRECTION")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_AT_VALIDATE_SHIFT_CORRECTION() As Message

    '===== MT CR04 =====
    <OperationContract(Action:="doUploadfromExcelCR04", ReplyAction:="doUploadfromExcelCR04")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function doUploadfromExcelCR04() As Message
    <OperationContract(Action:="doValidateProcessCR04", ReplyAction:="doValidateProcessCR04")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function doValidateProcessCR04() As Message
    '===================

     
    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of ATT008002RegDTO))

End Interface
