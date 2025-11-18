Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCB00150Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB00150StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCB00150StreamingService
    <OperationContract(Action:="GetYearList", ReplyAction:="GetYearList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYearList() As Message

    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeList() As Message

    <OperationContract(Action:="GetDimensionList", ReplyAction:="GetDimensionList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDimensionList() As Message

    <OperationContract(Action:="GetMedicalRuleList", ReplyAction:="GetMedicalRuleList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalRuleList() As Message


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ParamDTO(ByVal poPar As List(Of MCB00150DTO))

End Interface
