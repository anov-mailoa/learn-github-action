Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01100StreamingService

    <OperationContract(Action:="getListComboBox", ReplyAction:="getListComboBox")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListComboBox() As Message

    <OperationContract(Action:="getCmbTraining", ReplyAction:="getCmbTraining")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTraining() As Message

#Region "GET GRID LIST"

    <OperationContract(Action:="getFamilyList", ReplyAction:="getFamilyList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFamilyList() As Message

    <OperationContract(Action:="getEmergencyList", ReplyAction:="getEmergencyList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmergencyList() As Message

    <OperationContract(Action:="getBankAccList", ReplyAction:="getBankAccList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBankAccList() As Message

    <OperationContract(Action:="getWorkExpList", ReplyAction:="getWorkExpList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkExpList() As Message

    <OperationContract(Action:="getEducationList", ReplyAction:="getEducationList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEducationList() As Message

    <OperationContract(Action:="getTrainingList", ReplyAction:="getTrainingList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTrainingList() As Message

    <OperationContract(Action:="getLicenseList", ReplyAction:="getLicenseList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLicenseList() As Message

    <OperationContract(Action:="getLanguageList", ReplyAction:="getLanguageList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLanguageList() As Message

    <OperationContract(Action:="getMedicalHistoryList", ReplyAction:="getMedicalHistoryList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalHistoryList() As Message

#End Region
 
  
End Interface
