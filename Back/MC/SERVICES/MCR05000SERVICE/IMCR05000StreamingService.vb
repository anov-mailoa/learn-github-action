Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports MCR05000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR05000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR05000StreamingService

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy()
End Interface
