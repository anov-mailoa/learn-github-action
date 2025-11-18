Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT006003StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT006003StreamingService

    <OperationContract(Action:="getSocDocNameList", ReplyAction:="getSocDocNameList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSocDocNameList() As Message

    <OperationContract(Action:="getSocAttachList", ReplyAction:="getSocAttachList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSocAttachList() As Message


End Interface
