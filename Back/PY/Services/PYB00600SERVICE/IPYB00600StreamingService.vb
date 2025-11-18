Imports System.ServiceModel
Imports R_Common
Imports PYB00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00600StreamingService


    <OperationContract(Action:="GetListSalaryGroup", ReplyAction:="GetListSalaryGroup")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListSalaryGroup() As Message

    <OperationContract(Action:="GetProcess", ReplyAction:="GetProcess")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetProcess() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PYB00600DTO))

End Interface
