Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYI01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYI01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYI01000StreamingService

    <OperationContract(Action:="GetCmbPeriod", ReplyAction:="GetCmbPeriod")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function GetCmbPeriod() As Message

    <OperationContract(Action:="GetCmbSalaryGroup", ReplyAction:="GetCmbSalaryGroup")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetCmbSalaryGroup() As Message

    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetEmployeeList() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PYI01000DTO))

End Interface
