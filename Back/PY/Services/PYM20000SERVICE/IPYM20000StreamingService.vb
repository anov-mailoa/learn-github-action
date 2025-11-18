Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYM20000BACK

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM20000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM20000StreamingService

    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeList() As Message

    <OperationContract(Action:="GetEmployeeSearchList", ReplyAction:="GetEmployeeSearchList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeSearchList() As Message

    <OperationContract(Action:="AllEmailProcess", ReplyAction:="AllEmailProcess")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function AllEmailProcess() As Message

    <OperationContract(Action:="GetLookUpClassified", ReplyAction:="GetLookUpClassified")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLookUpClassified() As Message

    <OperationContract(Action:="GetLookUpEmployee", ReplyAction:="GetLookUpEmployee")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLookUpEmployee() As Message

    <OperationContract(Action:="GetCmbClassified", ReplyAction:="GetCmbClassified")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbClassified() As Message
End Interface
