Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports JCR00500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCR00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCR00500StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message

    <OperationContract(Action:="getDepartmentList", ReplyAction:="getDepartmentList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDepartmentList() As Message

    <OperationContract(Action:="getPositionList", ReplyAction:="getPositionList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPositionList() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParTenor As System.Collections.Generic.List(Of JCR00500DTO))

End Interface
