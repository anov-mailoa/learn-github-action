Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports LNM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00400StreamingService

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poReport As List(Of LNM00400ReportDTO),
              ByVal poparam2 As List(Of LNM00400HeaderDTO))

    <OperationContract(Action:="getUserList", ReplyAction:="getUserList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getUserList() As Message

    <OperationContract(Action:="getPermissionCategory", ReplyAction:="getPermissionCategory")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getPermissionCategory() As Message

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message

End Interface
