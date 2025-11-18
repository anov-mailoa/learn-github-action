Imports System.ServiceModel
Imports R_Common
Imports PYT00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00500StreamingService

    <OperationContract(Action:="getRapelTransaction", ReplyAction:="getRapelTransaction")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapelTransaction() As Message

    <OperationContract(Action:="getRapelComponent", ReplyAction:="getRapelComponent")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapelComponent() As Message

    <OperationContract(Action:="getRapelEmployee", ReplyAction:="getRapelEmployee")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapelEmployee() As Message

    <OperationContract(Action:="getRapelResult", ReplyAction:="getRapelResult")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapelResult() As Message

    <OperationContract(Action:="getRapelResultDetails", ReplyAction:="getRapelResultDetails")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapelResultDetails() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="getEmpHistory", ReplyAction:="getEmpHistory")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpHistory() As Message

    <OperationContract(Action:="getCompHistory", ReplyAction:="getCompHistory")> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompHistory() As Message

    <OperationContract(Action:="getYears", ReplyAction:="getYears")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getYears() As Message

    <OperationContract(Action:="getSalaryGroups", ReplyAction:="getSalaryGroups")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroups() As Message

    <OperationContract(Action:="getExcelData", ReplyAction:="getExcelData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExcelData() As Message

    <OperationContract(Action:="getRapelResultPrint", ReplyAction:="getRapelResultPrint")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapelResultPrint() As Message

    <OperationContract(Action:="getRapelResultComp", ReplyAction:="getRapelResultComp")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRapelResultComp() As Message

    <OperationContract(Action:="getList", ReplyAction:="getList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getList() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy1(ByVal poPar1 As List(Of PYT00500RapelComponentGridDTO),
               ByVal poPar2 As List(Of PYT00500RapelEmployeeGridDTO),
               ByVal poPar5 As List(Of PYT00500RapelResultDetailDTO),
               ByVal poPar6 As List(Of PYT00500GridDTO))
End Interface
