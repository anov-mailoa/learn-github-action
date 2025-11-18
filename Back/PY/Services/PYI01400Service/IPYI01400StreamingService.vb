Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYI01400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYI01400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYI01400StreamingService

    <OperationContract(Action:="GetCmbPeriod", ReplyAction:="GetCmbPeriod")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function GetCmbPeriod() As Message

    <OperationContract(Action:="GetTransactionInquiry", ReplyAction:="GetTransactionInquiry")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function GetTransactionInquiry() As Message

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PYI01400DTO))

End Interface
