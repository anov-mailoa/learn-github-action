Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR05240Back

Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR05240StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR05240StreamingService

    <OperationContract(Action:="GetTrainingList", ReplyAction:="GetTrainingList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTrainingList() As Message

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetReportData() As Message

    <OperationContract(Action:="getExcelData", ReplyAction:="getExcelData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExcelData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poTraining As PNR05240TreeDTO,
              ByVal poParam As PNR05240BackDTO)
End Interface
