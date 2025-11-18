Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports LNR01600Common
Imports LNR01600Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR01600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR01600StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of LNR01600DTO),
              ByVal poPar2 As System.Collections.Generic.List(Of LNR01600GridDTO))

End Interface
