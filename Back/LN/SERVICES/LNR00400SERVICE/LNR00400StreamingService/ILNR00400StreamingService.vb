Imports System.ServiceModel
Imports R_Common
Imports LNR00400Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00400StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParReport As System.Collections.Generic.List(Of ReportHeaderDTO))


End Interface
