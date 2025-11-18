Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports LNR01400Common
Imports LNR01400Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR01400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR01400StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

End Interface
