Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ATR10000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR10000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR10000StreamingService

    <OperationContract(Action:="Report", ReplyAction:="Report")> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="getAllEmployee", ReplyAction:="getAllEmployee")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getAllEmployee() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of ATR10000ReportDTO),
              popar2 As List(Of ATR10000DTO))

End Interface
