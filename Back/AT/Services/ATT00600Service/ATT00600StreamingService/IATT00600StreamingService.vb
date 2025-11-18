Imports System.ServiceModel
Imports R_Common
Imports ATT00600Back
Imports ATT00600Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00600StreamingService

    <OperationContract(Action:="getListCorrection", ReplyAction:="getListCorrection")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListCorrection() As Message

    <OperationContract(Action:="getListCorrectionHistory", ReplyAction:="getListCorrectionHistory")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListCorrectionHistory() As Message

    <OperationContract(Action:="getShiftList", ReplyAction:="getShiftList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getShiftList() As Message

    <OperationContract(Action:="getShiftLookup", ReplyAction:="getShiftLookup")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getShiftLookup() As Message

    <OperationContract(Action:="getHeaderDetail", ReplyAction:="getHeaderDetail")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeaderDetail() As Message

    <OperationContract(Action:="getCmbWorkGroup", ReplyAction:="getCmbWorkGroup")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbWorkGroup() As Message

    <OperationContract(Action:="RFT_GET_SCHEDULE_WORK_GROUP", ReplyAction:="RFT_GET_SCHEDULE_WORK_GROUP")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_SCHEDULE_WORK_GROUP() As Message

    <OperationContract(Action:="RFT_GET_SCHEDULE_WORK_GROUP_EMPLOYEE", ReplyAction:="RFT_GET_SCHEDULE_WORK_GROUP_EMPLOYEE")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_SCHEDULE_WORK_GROUP_EMPLOYEE() As Message

    <OperationContract(Action:="getShiftExcel", ReplyAction:="getShiftExcel")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getShiftExcel() As Message

End Interface
