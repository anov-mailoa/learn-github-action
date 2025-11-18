Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCI00100Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCI00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCI00100StreamingService

    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function GetEmployeeList() As Message

    <OperationContract(Action:="GetEmpSeparateLimitList", ReplyAction:="GetEmpSeparateLimitList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetEmpSeparateLimitList() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmpSummaryInfo(poParam As MCI00100ParamDTO) As MCI00100DTO

    <OperationContract(Action:="GetClaimTransList", ReplyAction:="GetClaimTransList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetClaimTransList() As Message

    <OperationContract(Action:="GetCorrectionTransList", ReplyAction:="GetCorrectionTransList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetCorrectionTransList() As Message

    <OperationContract(Action:="GetFamilyList", ReplyAction:="GetFamilyList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetFamilyList() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYear(pcCompId As String) As MCI00100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateFamilyInfo(poParam As MCI00100ParamDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal oData As List(Of MCI00100DTO))

End Interface
