Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCR04000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR04000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR04000StreamingService

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of MCR04000Dto))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

End Interface
