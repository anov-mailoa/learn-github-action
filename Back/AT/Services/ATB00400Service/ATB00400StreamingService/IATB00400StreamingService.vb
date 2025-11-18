Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ATB00400Back
Imports ATB00400Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATB00400StreamingService
    <OperationContract(Action:="getMasterWorkTable", ReplyAction:="getMasterWorkTable")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMasterWorkTable() As Message

    <OperationContract(Action:="GetResultPreviewProcess", ReplyAction:="GetResultPreviewProcess")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetResultPreviewProcess() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy()
End Interface
