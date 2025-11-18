Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT06200Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06200StreamingServices" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06200StreamingServices

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNT06200ReturnDtGridDto),
              ByVal poParam2 As List(Of PNT06200EmployeeGridDto))

    <OperationContract(Action:="getListEmpFac", ReplyAction:="getListEmpFac")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getListEmpFac() As Message

    <OperationContract(Action:="getListGridReturn", ReplyAction:="getListGridReturn")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getListGridReturn() As Message

    <OperationContract(Action:="getFacility", ReplyAction:="getFacility")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getFacility() As Message
End Interface
