Imports System.ServiceModel
Imports R_Common
Imports QAR01400Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01400StreamingService

    <OperationContract(Action:="getRetainDocument", ReplyAction:="getRetainDocument")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRetainDocument() As Message

    <OperationContract(Action:="getPrintReportTAB1", ReplyAction:="getPrintReportTAB1")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrintReportTAB1() As Message



End Interface
