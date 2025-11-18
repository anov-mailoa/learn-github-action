Imports System.ServiceModel
Imports R_Common
Imports PNM06000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM06000StreamingService

    <OperationContract(Action:="getLetterMaster", ReplyAction:="getLetterMaster")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLetterMaster() As Message

    <OperationContract(Action:="getCmbTransType", ReplyAction:="getCmbTransType")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTransType() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poGrid As List(Of PNM06000GridDTO))

End Interface
