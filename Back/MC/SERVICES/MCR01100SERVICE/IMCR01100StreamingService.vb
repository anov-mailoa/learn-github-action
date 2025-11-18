Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCR01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR01100StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of MCR01100Dto))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getYear", ReplyAction:="getYear")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getYear() As Message


End Interface
