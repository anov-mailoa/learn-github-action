Imports R_BackEnd
Imports R_Common
Imports PNM02000Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02000StreamingService

    <OperationContract(Action:="LocationData", ReplyAction:="LocationData")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLocation() As Message

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParamPNM00400Grid As List(Of PNM02000GridDTO))

End Interface
