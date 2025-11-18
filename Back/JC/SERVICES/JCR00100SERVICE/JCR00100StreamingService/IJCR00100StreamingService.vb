Imports JCR00100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports JCR00100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCR00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCR00100StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="getListReferrence", ReplyAction:="getListReferrence")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListReferrence() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParTenor As System.Collections.Generic.List(Of JCR00100ParDTO))


End Interface
