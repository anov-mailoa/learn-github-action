Imports System.ServiceModel
Imports R_Common
Imports PYM17000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM17000StreamingService

    <OperationContract(Action:="getSalaryGroup", ReplyAction:="getSalaryGroup")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroup() As Message

    <OperationContract(Action:="getEmpList", ReplyAction:="getEmpList")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpList() As Message

    <OperationContract(Action:="getEmpDetail", ReplyAction:="getEmpDetail")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpDetail() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateMaster(poParam As PYM17000DTO)

End Interface
