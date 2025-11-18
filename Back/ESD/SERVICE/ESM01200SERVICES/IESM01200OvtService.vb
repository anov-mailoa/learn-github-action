Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ESM01200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01200Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM01200OvtService
    Inherits R_IServicebase(Of ESM01200OvtDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDeptEmployee(poParam As ESM01200ParamDTO) As ESM01200OvtDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMinOvt(poParam As ESM01200ParamDTO) As ESM01200OvtDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTotalExcessHours(poParam As ESM01200ParamDTO) As ESM01200OvtDTO
  

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMinMaxOvtDate(poParam As ESM01200ParamDTO) As ESM01200OvtDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSumOvtTime(poParam As ESM01200ParamDTO) As Decimal

End Interface
