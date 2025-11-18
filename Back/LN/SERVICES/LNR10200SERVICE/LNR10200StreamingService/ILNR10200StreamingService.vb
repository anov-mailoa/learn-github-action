Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports LNR10200Common
Imports LNR10200Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR10200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR10200StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="getGrid", ReplyAction:="getGrid")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGrid() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of LNR10200DTO),
              ByVal poPar2 As System.Collections.Generic.List(Of LNR10200GridEmpDTO))

End Interface
