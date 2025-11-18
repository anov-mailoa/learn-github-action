Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATR00450Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00450StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR00450StreamingService

    <OperationContract(Action:="SPData", ReplyAction:="SPData")>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSP() As Message

    <OperationContract(Action:="AllEmployeeData", ReplyAction:="AllEmployeeData")>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAllEmployee() As Message


    <OperationContract(Action:="ListViewData", ReplyAction:="ListViewData")>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListView() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid As List(Of ATR00450ListViewDTO),
              POpar1 As List(Of ATR00450DTO))

End Interface
