Imports System.ServiceModel
Imports R_Common
Imports QAM00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00500StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00500StreamService
    <OperationContract(Action:="GetIsoTypeList", ReplyAction:="GetIsoTypeList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetIsoTypeList() As Message

    <OperationContract(Action:="GetClauseList", ReplyAction:="GetClauseList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetClauseList() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poGrid As QAM00500GridDto)
End Interface
