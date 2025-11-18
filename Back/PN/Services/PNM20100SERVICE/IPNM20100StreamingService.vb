Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM20100StreamingService
    <OperationContract(Action:="getListDiningSchedule", ReplyAction:="getListDiningSchedule")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDiningSchedule() As Message

    <OperationContract(Action:="getListComboBox", ReplyAction:="getListComboBox")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListComboBox() As Message
End Interface
