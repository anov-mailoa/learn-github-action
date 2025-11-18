Imports System.ServiceModel
Imports R_Common
Imports QAR01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01100StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01100StreamService

    <OperationContract(Action:="getListGrid", ReplyAction:="getListGrid")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGrid() As Message


    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="getSubReport", ReplyAction:="getSubReport")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSubReport() As Message



End Interface
