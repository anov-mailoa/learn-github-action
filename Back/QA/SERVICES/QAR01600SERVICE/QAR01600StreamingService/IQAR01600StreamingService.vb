Imports System.ServiceModel
Imports R_Common
Imports QAR01600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01600StreamingService

    <OperationContract(Action:="getComboDocOwner", ReplyAction:="getComboDocOwner")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboDocOwner() As Message

    <OperationContract(Action:="getComboDocType", ReplyAction:="getComboDocType")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboDocType() As Message

    <OperationContract(Action:="getPrintReport", ReplyAction:="getPrintReport")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrintReport() As Message




End Interface
