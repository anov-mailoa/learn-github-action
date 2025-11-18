Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00100StreamingService
    <OperationContract(Action:="getOvertime", ReplyAction:="getOvertime")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOvertime() As Message

    <OperationContract(Action:="getShift", ReplyAction:="getShift")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getShift() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="getFacility", ReplyAction:="getFacility")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFacility() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract(Action:="getPopUpEmployee", ReplyAction:="getPopUpEmployee")>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPopUpEmployee() As Message

    <OperationContract(Action:="getSchedule", ReplyAction:="getSchedule")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSchedule() As Message

    <OperationContract(Action:="getCmbIndex", ReplyAction:="getCmbIndex")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbIndex() As Message


End Interface
