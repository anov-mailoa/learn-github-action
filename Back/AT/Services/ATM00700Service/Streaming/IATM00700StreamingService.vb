Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00700Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00700StreamingService

    <OperationContract(Action:="getLeaveManagement", ReplyAction:="getLeaveManagement")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveManagement() As Message

    <OperationContract(Action:="getMultiRange", ReplyAction:="getMultiRange")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMultiRange() As Message


    <OperationContract(Action:="getAnnualLeave", ReplyAction:="getAnnualLeave")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAnnualLeave() As Message


    <OperationContract(Action:="getDispensationLeave", ReplyAction:="getDispensationLeave")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDispensationLeave() As Message



    <OperationContract(Action:="getSpecialLeave", ReplyAction:="getSpecialLeave")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSpecialLeave() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract(Action:="getListRules", ReplyAction:="getListRules")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListRules() As Message

    <OperationContract(Action:="getListCategory", ReplyAction:="getListCategory")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListCategory() As Message


End Interface
