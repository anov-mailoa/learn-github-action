Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports R_Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00800ListStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00800ListStreamingService

    <OperationContract(Action:="getAttCorrectionList", ReplyAction:="getAttCorrectionList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getAttCorrectionList() As Message

    <OperationContract(Action:="getAttCorrectionDetail", ReplyAction:="getAttCorrectionDetail")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getAttCorrectionDetail() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy()

End Interface
