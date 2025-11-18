Imports System.ServiceModel
Imports R_Common
Imports JCT01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCT01000StreamingService

    <OperationContract(Action:="getListEmployee", ReplyAction:="getListEmployee")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListEmployee() As Message

    <OperationContract(Action:="getInformationList", ReplyAction:="getInformationList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getInformationList() As Message

    <OperationContract(Action:="getListEmployeeDetail", ReplyAction:="getListEmployeeDetail")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListEmployeeDetail() As Message

    <OperationContract(Action:="PrintProcess", ReplyAction:="PrintProcess")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function PrintProcess() As Message

    <OperationContract(Action:="GetCompetencyResultList", ReplyAction:="GetCompetencyResultList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCompetencyResultList() As Message

    <OperationContract(Action:="GetFailedEmployees", ReplyAction:="GetFailedEmployees")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetFailedEmployees() As Message

    <OperationContract(Action:="GetListTrainingHistory", ReplyAction:="GetListTrainingHistory")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListTrainingHistory() As Message

    <OperationContract(Action:="GetListHistoryCompetency", ReplyAction:="GetListHistoryCompetency")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListHistoryCompetency() As Message

    <OperationContract(Action:="GetDefaultScoringList", ReplyAction:="GetDefaultScoringList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDefaultScoringList() As Message

    <OperationContract(Action:="GetDownloadInfo", ReplyAction:="GetDownloadInfo")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDownloadInfo() As Message
End Interface
