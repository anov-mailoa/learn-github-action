Imports System.ServiceModel
Imports R_Common
Imports JCI00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports JCI00200Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCI00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCI00200StreamingService

    <OperationContract(Action:="getLookup", ReplyAction:="getLookup")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookup() As Message

    <OperationContract(Action:="getListEmployee", ReplyAction:="getListEmployee")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListEmployee() As Message

    <OperationContract(Action:="getComboBox", ReplyAction:="getComboBox")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboBox() As Message

    <OperationContract(Action:="getListTraction", ReplyAction:="getListTraction")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListTransaction() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookupDes(poParam As JCI00200DTO) As JCI00200DTO



End Interface
