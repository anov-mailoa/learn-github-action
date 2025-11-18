Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT04200Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT04200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT04200StreamingService

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PNT04200GridDTO))

    <OperationContract(Action:="getPntTransactionHd", ReplyAction:="getPntTransactionHd")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPntTransactionHd() As Message

    <OperationContract(Action:="getCompany", ReplyAction:="getCompany")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getCompany() As Message

End Interface
