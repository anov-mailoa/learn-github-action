Imports System.ServiceModel
Imports R_Common
Imports LNR00500Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00500StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="getLoanTypeList", ReplyAction:="getLoanTypeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLoanTypeList() As Message

    <OperationContract(Action:="getPeriodList", ReplyAction:="getPeriodList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPeriodList() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poReport As System.Collections.Generic.List(Of HeaderReportDTO))

End Interface
