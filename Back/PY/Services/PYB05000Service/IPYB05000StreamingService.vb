Imports System.ServiceModel
Imports R_Common
Imports PYB05000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB05000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB05000StreamingService

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYB05000DTO))

    <OperationContract(Action:="GetGvSalaryProcess", ReplyAction:="GetGvSalaryProcess")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvSalaryProcess() As Message


    <OperationContract(Action:="getBankTransferData", ReplyAction:="getBankTransferData")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBankTransferData() As Message

    <OperationContract(Action:="getTemplateList", ReplyAction:="getTemplateList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTemplateList() As Message

    <OperationContract(Action:="getCmbBank", ReplyAction:="getCmbBank")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbBank() As Message

    <OperationContract(Action:="Get_ProcessPeriod", ReplyAction:="Get_ProcessPeriod")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function Get_ProcessPeriod() As Message


End Interface
