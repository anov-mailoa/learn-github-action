Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCR07000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR07000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR07000StreamingService

    <OperationContract(Action:="getDataReport", ReplyAction:="getDataReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getDataReport() As Message

End Interface
