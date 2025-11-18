Imports System.ServiceModel
Imports R_Common
Imports PYB01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB01100StreamingService

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poPar2 As PYB01100DTO, poPar3 As PYB01100GridDTO)

    <OperationContract(Action:="GetGvSalaryGroupList", ReplyAction:="GetGvSalaryGroupList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvSalaryGroupList() As Message

    <OperationContract(Action:="getPeriodList", ReplyAction:="getPeriodList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPeriodList() As Message

    <OperationContract(Action:="getYearList", ReplyAction:="getYearList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getYearList() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPeriod(poParam As PYB01100DTO) As String

End Interface
