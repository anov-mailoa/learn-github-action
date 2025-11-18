Imports System.ServiceModel
Imports ESS_PUB_BACK
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISIAPP_PUB_DTOStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESS_PUB_StreamingService

    <OperationContract(Action:="RFT_GET_GEOGRAPHY", ReplyAction:="RFT_GET_GEOGRAPHY")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_GEOGRAPHY() As Message

    <OperationContract(Action:="RFT_GET_GSB_CODE_INFO", ReplyAction:="RFT_GET_GSB_CODE_INFO")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_GSB_CODE_INFO() As Message

    <OperationContract(Action:="RFT_ESS_TRANSACTION_APPROVAL_STATUS", ReplyAction:="RFT_ESS_TRANSACTION_APPROVAL_STATUS")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_ESS_TRANSACTION_APPROVAL_STATUS() As Message

    <OperationContract(Action:="RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST", ReplyAction:="RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_ESS_GET_EMPLOYEE_SUB_PROGRAM_LIST() As Message

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RFN_VALIDATE_EMP_APPROVAL_POSITIONS(poParam As ESS_PUB_ParamDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub ParamDTO(ByVal poPar1 As List(Of CMB_DTOReguler))
End Interface
