Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYM01400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR11000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR11000StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

End Interface
