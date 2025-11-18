Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR05100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR05100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR05100StreamingService

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR05100Dto))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getAllEmployee", ReplyAction:="getAllEmployee")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getAllEmployee() As Message

End Interface
