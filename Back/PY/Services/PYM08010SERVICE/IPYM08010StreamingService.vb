Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYM08010Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM08000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM08010StreamingService

    <OperationContract(Action:="getListMapping", ReplyAction:="getListMapping")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListMapping() As Message

    <OperationContract(Action:="getCmbCenter", ReplyAction:="getCmbCenter")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbCenter() As Message

    <OperationContract(Action:="getCmbGrupGaji", ReplyAction:="getCmbGrupGaji")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbGrupGaji() As Message

    <OperationContract(Action:="getLookUpGLAccount", ReplyAction:="getLookUpGLAccount")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getLookUpGLAccount() As Message

    <OperationContract(Action:="generateMapping", ReplyAction:="generateMapping")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function generateMapping() As Message

End Interface
