Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100JobCompetencyStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100JobCompetencyStreamingService

    <OperationContract(Action:="getCmbCatCompetency", ReplyAction:="getCmbCatCompetency")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCatCompetency() As Message

    <OperationContract(Action:="getCmbCompetency", ReplyAction:="getCmbCompetency")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCompetency() As Message

    <OperationContract(Action:="getCmbBenchmark", ReplyAction:="getCmbBenchmark")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbBenchmark() As Message

    <OperationContract(Action:="getCmbTrainingCategory", ReplyAction:="getCmbTrainingCategory")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTrainingCategory() As Message

    <OperationContract(Action:="getCategoryCompetency", ReplyAction:="getCategoryCompetency")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCategoryCompetency() As Message

    <OperationContract(Action:="getCmbTrainingSubject", ReplyAction:="getCmbTrainingSubject")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTrainingSubject() As Message

    <OperationContract(Action:="getRelatedTraining", ReplyAction:="getRelatedTraining")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRelatedTraining() As Message


    <OperationContract(Action:="getScoringInfoList", ReplyAction:="getScoringInfoList")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getScoringInfoList() As Message

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParPNM03100Streaming As System.Collections.Generic.List(Of PNM03100JobCompetencyHeaderDTO))

End Interface
