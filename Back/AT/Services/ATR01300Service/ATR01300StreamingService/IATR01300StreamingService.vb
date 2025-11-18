Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATR01300Back
Imports ATR01300Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR01300StreamingService

    <OperationContract(Action:="SPData", ReplyAction:="SPData")>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSP() As Message

    <OperationContract(Action:="ListViewData", ReplyAction:="ListViewData")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListView() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of ATR01300DTO),
              poParDTO As List(Of ATR01300ListViewDTO))

End Interface
