Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM20300StreamingService
    <OperationContract(Action:="getListDiningDate", ReplyAction:="getListDiningDate")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDiningDate() As Message

    <OperationContract(Action:="getListComboBox", ReplyAction:="getListComboBox")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListComboBox() As Message

    <OperationContract(Action:="getListVisitor", ReplyAction:="getListVisitor")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListVisitor() As Message

End Interface
