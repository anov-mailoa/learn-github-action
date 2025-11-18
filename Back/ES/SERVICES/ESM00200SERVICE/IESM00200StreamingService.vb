Imports System.ServiceModel
Imports R_Common
Imports ESM00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00200StreamingService

    <OperationContract(Action:="getProgramList", ReplyAction:="getProgramList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProgramList() As Message

    <OperationContract(Action:="getReasonCodeList", ReplyAction:="getReasonCodeList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReasonCodeList() As Message

End Interface
