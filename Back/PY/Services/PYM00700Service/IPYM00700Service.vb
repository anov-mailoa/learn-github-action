Imports System.ServiceModel
Imports PYM00700Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00700Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00700Service
    Inherits R_IServicebase(Of PYM00700DTO)

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function cekSalaryTransferHd(poEntity As PYM00700DTO) As Boolean


    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkBankAccount(poEntity As PYM00700DTO) As Boolean

    '   <OperationContract()> _
    '  <FaultContract(GetType(R_ServiceExceptions))> _
    '   Function getTransferCodeDt(poEntity As PYM00700DTO) As List(Of PYM00700DTO)

    '   <OperationContract()> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    '   Function getSalaryTransferHd(poEntity As PYM00700DTO) As List(Of PYM00700DTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Function checkSalaryTransferHd(poEntity As PYM00700DTO) As PYM00700DTO
End Interface
