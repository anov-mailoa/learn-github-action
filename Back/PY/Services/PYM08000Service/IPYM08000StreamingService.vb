Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYM08000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM08000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM08000StreamingService

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(poParam2 As List(Of PYM08000UnboundDTO))

    <OperationContract(Action:="getGLHeader", ReplyAction:="getGLHeader")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getGLHeader() As Message

    <OperationContract(Action:="getGLDetail", ReplyAction:="getGLDetail")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getGLDetail() As Message

End Interface
