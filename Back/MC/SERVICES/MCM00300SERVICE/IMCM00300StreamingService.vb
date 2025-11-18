Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM00300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCM00300StreamingService

    <OperationContract(Action:="GetBankList", ReplyAction:="GetBankList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetBankList() As Message

    <OperationContract(Action:="GetAccountList", ReplyAction:="GetAccountList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetAccountList() As Message

    <OperationContract(Action:="GetDlogList", ReplyAction:="GetDlogList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogList() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poGrid As MCM00300GridDTO)

End Interface
