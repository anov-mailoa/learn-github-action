Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00600StreamingService

    <OperationContract(Action:="SocializationReasonList", ReplyAction:="SocializationReasonList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function SocializationReasonList() As Message

    <OperationContract(Action:="SocializationRegList", ReplyAction:="SocializationRegList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function SocializationRegList() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poPar1 As List(Of QAT00600RegDTO))
End Interface
