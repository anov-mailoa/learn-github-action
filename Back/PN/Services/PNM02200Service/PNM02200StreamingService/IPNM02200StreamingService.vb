Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02200SteramingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02200StreamingService

    <OperationContract(Action:="CompetencyCategories", ReplyAction:="CompetencyCategories")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompetencyCategories() As Message

    <OperationContract(Action:="CompetencyInfo", ReplyAction:="CompetencyInfo")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompetencyInfo() As Message

    <OperationContract(Action:="Score", ReplyAction:="Score")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getScore() As Message

    <OperationContract(Action:="getCmbActive", ReplyAction:="getCmbActive")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbActive() As Message

    <OperationContract(Action:="DefaultBenchmark", ReplyAction:="DefaultBenchmark")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDefaultBenchmark() As Message

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getRelatedTraining", ReplyAction:="getRelatedTraining")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getRelatedTraining() As Message


    <OperationContract(Action:="getCompetencyScoreList", ReplyAction:="getCompetencyScoreList")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompetencyScoreList() As Message

    <OperationContract(Action:="getMultipleTraining", ReplyAction:="getMultipleTraining")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMultipleTraining() As Message

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParamDetail As System.Collections.Generic.List(Of PNM02200DetailDTO))


End Interface
