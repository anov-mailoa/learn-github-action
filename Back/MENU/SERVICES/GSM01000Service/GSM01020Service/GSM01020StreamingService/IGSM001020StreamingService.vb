Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01020StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01020StreamingService

    <OperationContract(Action:="getListAppUser", ReplyAction:="getListAppUser")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListAppUser() As Message

    <OperationContract(Action:="getReplacementList", ReplyAction:="getReplacementList")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReplacementList() As Message

    <OperationContract(Action:="getListUser", ReplyAction:="getListUser")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListUser() As Message

    <OperationContract(Action:="getDepartment", ReplyAction:="getDepartment")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDepartment() As Message
 
End Interface
