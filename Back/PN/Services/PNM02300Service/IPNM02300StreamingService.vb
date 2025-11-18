Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNM02300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02300StreamingService

    <OperationContract(Action:="getTrainingCategories", ReplyAction:="getTrainingCategories")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getTrainingCategories() As Message

    <OperationContract(Action:="getTrainingSubject", ReplyAction:="getTrainingSubject")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getTrainingSubject() As Message

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message
End Interface
