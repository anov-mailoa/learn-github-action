Imports System.ServiceModel
Imports R_Common
Imports PYT00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00600StreamingService

    <OperationContract(Action:="getCancellationListData", ReplyAction:="getCancellationListData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCancellationList() As Message

    <OperationContract(Action:="getCancellableListData", ReplyAction:="getCancellableListData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCancellableList() As Message

    <OperationContract(Action:="getHeaderGridData", ReplyAction:="getHeaderGridData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeaderGridData() As Message

End Interface
