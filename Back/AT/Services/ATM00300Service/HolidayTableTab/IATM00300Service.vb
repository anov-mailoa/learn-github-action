Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM0300Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00300Service
    Inherits R_IServicebase(Of ATM00300DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As List(Of ATM00300DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSystemParam(poParam As ATM00300DTO) As ATM00300DTO


End Interface
