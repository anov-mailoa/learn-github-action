Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports LNR10300COMMON
Imports LNR10300BACK
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR10300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR10300StreamingService

    <OperationContract(Action:="GetReport", ReplyAction:="GetReport")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReport() As Message

    <OperationContract(Action:="GetPeriodList", ReplyAction:="GetPeriodList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetPeriodList() As Message

    <OperationContract(Action:="GetLoanTypeList", ReplyAction:="GetLoanTypeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLoanTypeList() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of LNR10300DTO))

End Interface
