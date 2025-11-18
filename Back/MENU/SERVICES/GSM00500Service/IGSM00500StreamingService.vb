Imports System.ServiceModel
Imports R_Common
Imports GSM00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00500StreamingService


    <OperationContract(Action:="getListOfDepartments", ReplyAction:="getListOfDepartments")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListOfDepartments() As Message

    <OperationContract(Action:="getCmbCenterCode", ReplyAction:="getCmbCenterCode")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCenterCode() As Message

    <OperationContract(Action:="getCmbUserId", ReplyAction:="getCmbUserId")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbUserId() As Message

    <OperationContract(Action:="getListOfUserDepartment", ReplyAction:="getListOfUserDepartment")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListOfUserDepartment() As Message

    <OperationContract(Action:="getListOfUser", ReplyAction:="getListOfUser")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListOfUser() As Message

    <OperationContract(Action:="getListUserCopyDepartment", ReplyAction:="getListUserCopyDepartment")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListUserCopyDepartment() As Message


    <OperationContract(Action:="getListOfUserMultiple", ReplyAction:="getListOfUserMultiple")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListOfUserMultiple() As Message

    <OperationContract(Action:="getCmbFromDept", ReplyAction:="getCmbFromDept")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbFromDept() As Message

    <OperationContract(Action:="getDeptDB", ReplyAction:="getDeptDB")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDeptDB() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of GSM00500TreeDTO),
              poPar2 As List(Of GSM00511DTO))

End Interface
