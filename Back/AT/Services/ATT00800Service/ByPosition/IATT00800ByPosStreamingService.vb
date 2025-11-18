Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00800ByPosStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00800ByPosStreamingService

    <OperationContract(Action:="getAttCorrectionByPosition", ReplyAction:="getAttCorrectionByPosition")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getAttCorrectionByPosition() As Message

    <OperationContract(Action:="getShiftCode", ReplyAction:="getShiftCode")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getShiftCode() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of ATT00800ByPosRegDTO))

End Interface
