Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNT03100Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03100StreamingService

    <OperationContract(Action:="getCmbGrade", ReplyAction:="getCmbGrade")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbGrade() As Message


    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="RFT_GET_STATCHANGE_EMPLOYEE_TYPES", ReplyAction:="RFT_GET_STATCHANGE_EMPLOYEE_TYPES")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_STATCHANGE_EMPLOYEE_TYPES() As Message

End Interface
