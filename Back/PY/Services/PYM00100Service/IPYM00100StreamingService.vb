Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00100StreamingService

    <OperationContract(Action:="getDataProportionalAtt", ReplyAction:="getDataProportionalAtt")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataProportionalAtt() As Message


    <OperationContract(Action:="GetComboReportId", ReplyAction:="GetComboReportId")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetComboReportId() As Message


    <OperationContract(Action:="GetComboTemplateId", ReplyAction:="GetComboTemplateId")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetComboTemplateId() As Message

End Interface
