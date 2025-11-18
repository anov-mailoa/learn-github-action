Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM20200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM20200StreamingService
    <OperationContract(Action:="getListDiningDate", ReplyAction:="getListDiningDate")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDiningDate() As Message

    <OperationContract(Action:="getListComboBox", ReplyAction:="getListComboBox")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListComboBox() As Message

    <OperationContract(Action:="getListEmployee", ReplyAction:="getListEmployee")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListEmployee() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub dummy(poParam As PNM20200DTO)
End Interface
