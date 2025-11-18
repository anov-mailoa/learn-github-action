Imports System.ServiceModel
Imports R_Common
Imports QAR01500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01500StreamingService

    <OperationContract(Action:="getListDocOwner", ReplyAction:="getListDocOwner")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDocOwner() As Message

    <OperationContract(Action:="getComboDeptList", ReplyAction:="getComboDeptList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboDeptList() As Message

    <OperationContract(Action:="getDocList", ReplyAction:="getDocList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocList() As Message

    <OperationContract(Action:="getPrintReportTAB1", ReplyAction:="getPrintReportTAB1")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrintReportTAB1() As Message

    <OperationContract(Action:="getPrintReportTAB2", ReplyAction:="getPrintReportTAB2")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrintReportTAB2() As Message



End Interface
