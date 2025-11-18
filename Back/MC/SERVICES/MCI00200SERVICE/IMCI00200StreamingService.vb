Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCI00200Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCI00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCI00200StreamingService
    <OperationContract(Action:="GetOutstandingTransaction", ReplyAction:="GetOutstandingTransaction")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function GetOutstandingTransaction() As Message

    <OperationContract(Action:="GetOutstandingEmployees", ReplyAction:="GetOutstandingEmployees")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetOutstandingEmployees() As Message

    <OperationContract(Action:="GetTransactionType", ReplyAction:="GetTransactionType")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetTransactionType() As Message

End Interface
