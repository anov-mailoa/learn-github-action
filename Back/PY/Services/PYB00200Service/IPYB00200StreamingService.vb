Imports System.ServiceModel
Imports R_Common
Imports PYB00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00200StreamingService


    <OperationContract(Action:="GetGvSalaryProcess", ReplyAction:="GetGvSalaryProcess")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvSalaryProcess() As Message

    <OperationContract(Action:="GetGvResignSalaryProcess", ReplyAction:="GetGvResignSalaryProcess")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvResignSalaryProcess() As Message

    <OperationContract(Action:="GetGvEmployeeGroup", ReplyAction:="GetGvEmployeeGroup")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvEmployeeGroup() As Message

    <OperationContract(Action:="GetGvResignEmployee", ReplyAction:="GetGvResignEmployee")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvResignEmployee() As Message

    <OperationContract(Action:="getCmbSalaryGroup", ReplyAction:="getCmbSalaryGroup")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSalaryGroup() As Message

    <OperationContract(Action:="getCmbProcessCode", ReplyAction:="getCmbProcessCode")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbProcessCode() As Message

    <OperationContract(Action:="getGridEmployee", ReplyAction:="getGridEmployee")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridEmployee() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

End Interface
