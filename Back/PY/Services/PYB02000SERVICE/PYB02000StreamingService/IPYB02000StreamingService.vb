Imports System.ServiceModel
Imports R_Common
Imports PYB02000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB02000StreamingService

    <OperationContract(Action:="GetPeriode", ReplyAction:="GetPeriode")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetPeriode() As Message

    <OperationContract(Action:="GetGroup", ReplyAction:="GetGroup")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGroup() As Message

    <OperationContract(Action:="GetKPP", ReplyAction:="GetKPP")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetKPP() As Message

    <OperationContract(Action:="GenerateFile", ReplyAction:="GenerateFile")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GenerateFile() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYB02000DTO))

End Interface
