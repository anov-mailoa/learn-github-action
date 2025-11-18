Imports System.ServiceModel
Imports R_Common
Imports PYM00100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00100Service

    Inherits R_IServicebase(Of PYM00100DTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRateTypeCode(poParam As PYM00100DTO) As List(Of PYM00100CmbDTO)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecord(poParam As PYM00100DTO) As PYM00100DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckFinalizeTax(poParam As PYM00100DTO) As Boolean

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DUMMY(poParam As PYM00100GridProportionalDTO)
End Interface
