Imports System.ServiceModel
Imports R_Common
Imports QAI00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAI00200StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAI00200StreamService
    <OperationContract(Action:="GetHISTDOCLIST", ReplyAction:="GetHISTDOCLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHISTDOCLIST() As Message

    <OperationContract(Action:="GetSOCLIST", ReplyAction:="GetSOCLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSOCLIST() As Message

    <OperationContract(Action:="GetHISTFILINGLIST", ReplyAction:="GetHISTFILINGLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHISTFILINGLIST() As Message

    <OperationContract(Action:="GetRELPOS", ReplyAction:="GetRELPOS")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRELPOS() As Message

    <OperationContract(Action:="GetHISTRELPOSLIST", ReplyAction:="GetHISTRELPOSLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHISTRELPOSLIST() As Message

    <OperationContract(Action:="GetRETAINERS", ReplyAction:="GetRETAINERS")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRETAINERS() As Message

    <OperationContract(Action:="GetHISTRETAINERSLIST", ReplyAction:="GetHISTRETAINERSLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHISTRETAINERSLIST() As Message

    <OperationContract(Action:="GetCLAUSES", ReplyAction:="GetCLAUSES")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCLAUSES() As Message

    <OperationContract(Action:="GetHISTCLAUSES", ReplyAction:="GetHISTCLAUSES")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHISTCLAUSES() As Message

    <OperationContract(Action:="GetDOC_SOCIALIZATION", ReplyAction:="GetDOC_SOCIALIZATION")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDOC_SOCIALIZATION() As Message

    <OperationContract(Action:="GetRELDOCLIST", ReplyAction:="GetRELDOCLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRELDOCLIST() As Message

    <OperationContract(Action:="GetRELDOCRETAINERS", ReplyAction:="GetRELDOCRETAINERS")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRELDOCRETAINERS() As Message

    <OperationContract(Action:="GetRELDOC_SOCIALIZATION", ReplyAction:="GetRELDOC_SOCIALIZATION")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRELDOC_SOCIALIZATION() As Message

    <OperationContract(Action:="GetRSP_QAI00200_GETRELDOC", ReplyAction:="GetRSP_QAI00200_GETRELDOC")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRSP_QAI00200_GETRELDOC() As Message

    <OperationContract(Action:="GetRSP_QAI00200_GETREVISION", ReplyAction:="GetRSP_QAI00200_GETREVISION")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRSP_QAI00200_GETREVISION() As Message

    <OperationContract(Action:="getCmbPositionCodeRetainer", ReplyAction:="getCmbPositionCodeRetainer")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPositionCodeRetainer() As Message

    <OperationContract(Action:="getCmbDocType", ReplyAction:="getCmbDocType")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDocType() As Message


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(
              ByVal poGrid As QAI00200GridDto)
End Interface
