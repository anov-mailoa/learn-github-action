Imports System.ServiceModel
Imports R_Common
Imports JCT00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCT00300StreamingService

    <OperationContract(Action:="getListEmployee", ReplyAction:="getListEmployee")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListEmployee() As Message

    <OperationContract(Action:="getComboDept", ReplyAction:="getComboDept")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboDept() As Message

    <OperationContract(Action:="getEvaluation", ReplyAction:="getEvaluation")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEvaluation() As Message

End Interface
