Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports QAF01000Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAF01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAF01000StreamingService

    <OperationContract(Action:="getTreePosition", ReplyAction:="getTreePosition")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTreePosition() As Message

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of QAF01000StreamingDTO))


End Interface
