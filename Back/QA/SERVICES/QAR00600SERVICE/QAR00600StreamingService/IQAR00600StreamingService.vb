Imports System.ServiceModel
Imports R_Common
Imports QAR00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR00600StreamingService

    <OperationContract(Action:="getListTransDepartment", ReplyAction:="getListTransDepartment")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListTransDepartment() As Message

    <OperationContract(Action:="getSocializationProcess", ReplyAction:="getSocializationProcess")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSocializationProcess() As Message

    <OperationContract(Action:="getPrintReportTAB1", ReplyAction:="getPrintReportTAB1")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrintReportTAB1() As Message


    <OperationContract(Action:="getReportSocializationInfo", ReplyAction:="getReportSocializationInfo")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportSocializationInfo() As Message

    <OperationContract(Action:="getReportSocializationDocument", ReplyAction:="getReportSocializationDocument")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportSocializationDocument() As Message

    <OperationContract(Action:="getReportSocializationAttachment", ReplyAction:="getReportSocializationAttachment")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportSocializationAttachment() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar2 As QAR00600ReportDTO)

End Interface
