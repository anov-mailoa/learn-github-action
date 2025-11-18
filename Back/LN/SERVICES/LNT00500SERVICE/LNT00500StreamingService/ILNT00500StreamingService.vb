Imports System.ServiceModel
Imports R_Common
Imports LNT00500Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00500StreamingService

    <OperationContract(Action:="getCmbTransaction", ReplyAction:="getCmbTransaction")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTransaction() As Message

    <OperationContract(Action:="getTransList", ReplyAction:="getTransList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransList() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00500Dto))

End Interface
