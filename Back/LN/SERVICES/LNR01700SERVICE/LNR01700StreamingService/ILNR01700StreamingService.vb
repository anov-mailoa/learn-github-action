Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports LNR01700Common
Imports LNR01700Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR01700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR01700StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of LNR01700DTO),
              ByVal poPar2 As System.Collections.Generic.List(Of LNR01700GridDTO))

End Interface
