Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNT03400Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03400StreamingService

    <OperationContract(Action:="getTransactionList", ReplyAction:="getTransactionList")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionList() As Message

    <OperationContract(Action:="getEmployeeList", ReplyAction:="getEmployeeList")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeList() As Message

End Interface
