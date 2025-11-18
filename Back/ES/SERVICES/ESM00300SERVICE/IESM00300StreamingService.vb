Imports System.ServiceModel
Imports R_Common
Imports ESM00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00300StreamingService

    <OperationContract(Action:="getList", ReplyAction:="getList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getList() As Message

    <OperationContract(Action:="getChkCmbData", ReplyAction:="getChkCmbData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getChkCmbData() As Message

End Interface
