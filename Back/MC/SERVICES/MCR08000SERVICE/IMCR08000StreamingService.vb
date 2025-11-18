Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCR08000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR08000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR08000StreamingService

    <OperationContract(Action:="getDataReport", ReplyAction:="getDataReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getDataReport() As Message

End Interface
