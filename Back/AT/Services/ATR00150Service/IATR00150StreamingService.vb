Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ATR00150Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00150StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR00150StreamingService

    <OperationContract(Action:="Report", ReplyAction:="Report")> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="getAllEmployee", ReplyAction:="getAllEmployee")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getAllEmployee() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of ATR00150ReportDTO),
              popar2 As List(Of ATR00150DTO))

End Interface
