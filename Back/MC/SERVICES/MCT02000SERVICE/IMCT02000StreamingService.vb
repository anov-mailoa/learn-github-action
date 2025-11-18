Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports MCT02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT02000StreamingService

    <OperationContract(Action:="getMctCorrection", ReplyAction:="getMctCorrection")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMctCorrection() As Message

    <OperationContract(Action:="getMedicalItem", ReplyAction:="getMedicalItem")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalItem() As Message

    <OperationContract(Action:="GetMedicalItemCorrectionList", ReplyAction:="GetMedicalItemCorrectionList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalItemCorrectionList() As Message

    <OperationContract(Action:="getDownloadData", ReplyAction:="getDownloadData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDownloadData() As Message

    <OperationContract(Action:="getLimitCorrectionDetail", ReplyAction:="getLimitCorrectionDetail")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLimitCorrectionDetail() As Message

    <OperationContract(Action:="getEmpL", ReplyAction:="getEmpL")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpL() As Message

End Interface
