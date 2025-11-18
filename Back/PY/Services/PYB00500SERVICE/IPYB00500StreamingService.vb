Imports System.ServiceModel
Imports R_Common
Imports PYB00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00500StreamingService

    <OperationContract(Action:="getCmbYear", ReplyAction:="getCmbYear")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbYear() As Message

    <OperationContract(Action:="getEmpList", ReplyAction:="getEmpList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpList() As Message


End Interface
