Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM20000StreamingService
    <OperationContract(Action:="getListCanteen", ReplyAction:="getListCanteen")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListCanteen() As Message

    <OperationContract(Action:="getListSupplier", ReplyAction:="getListSupplier")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListSupplier() As Message

    <OperationContract(Action:="getListDiningTime", ReplyAction:="getListDiningTime")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDiningTime() As Message

    <OperationContract(Action:="getListGuest", ReplyAction:="getListGuest")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListGuest() As Message


End Interface
