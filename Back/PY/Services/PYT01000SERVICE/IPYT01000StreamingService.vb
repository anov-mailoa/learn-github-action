Imports System.ServiceModel
Imports R_Common
Imports PYT01000Back
'Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT01000StreamingService

    <OperationContract(Action:="getTransactionList", ReplyAction:="getTransactionList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionList() As Message

    <OperationContract(Action:="getCmbYear", ReplyAction:="getCmbYear")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbYear() As Message

    <OperationContract(Action:="getRapidCompList", ReplyAction:="getRapidCompList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapidCompList() As Message

    <OperationContract(Action:="getDetailEmployeeList", ReplyAction:="getDetailEmployeeList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailEmployeeList() As Message

    <OperationContract(Action:="getLookupEmployeeList", ReplyAction:="getLookupEmployeeList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookupEmployeeList() As Message

    <OperationContract(Action:="getDTPResultEmployee", ReplyAction:="getDTPResultEmployee")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDTPResultEmployee() As Message

    <OperationContract(Action:="getDTPResultDetail", ReplyAction:="getDTPResultDetail")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDTPResultDetail() As Message

End Interface
