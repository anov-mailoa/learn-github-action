Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR08010Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR08000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR08010StreamingService

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTemplateDetail(poParam As PYR08010DTO) As PYR08010DTO

    <OperationContract(Action:="getInterfaceData", ReplyAction:="getInterfaceData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getInterfaceData() As Message

    <OperationContract(Action:="getList", ReplyAction:="getList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getList() As Message


End Interface
