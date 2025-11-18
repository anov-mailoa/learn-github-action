Imports System.ServiceModel
Imports LNR01200Back
Imports System.ServiceModel.Channels
Imports LNR01200Common
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR01200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR01200StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

End Interface
