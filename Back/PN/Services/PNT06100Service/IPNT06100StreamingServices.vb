Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT06100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06100StreamingServices" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06100StreamingServices

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNT06100AssignmentDtGridDto),
              ByVal poParam2 As List(Of PNT06100EmployeeGridDto))

    <OperationContract(Action:="getListEmpFac", ReplyAction:="getListEmpFac")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getListEmpFac() As Message

    <OperationContract(Action:="getListGridAssignment", ReplyAction:="getListGridAssignment")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getListGridAssignment() As Message

    <OperationContract(Action:="getFacility", ReplyAction:="getFacility")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getFacility() As Message

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

End Interface
