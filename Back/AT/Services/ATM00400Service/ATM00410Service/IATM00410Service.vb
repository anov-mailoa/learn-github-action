Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ATM00400Back
Imports ATM00400Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM0410Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00410Service
    Inherits R_IServicebase(Of ATM00400DTO)

    ' <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    ' Function getAtmOffice(poParam As ATM00400DTO) As List(Of ATM00400DTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function cekAtmCard(poParam As ATM00400DTO) As List(Of ATM00400StreamingDTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Function SaveBatch(pcCompId As String, poNewEntity As List(Of ATM00400DTO), poCRUDMode As R_Common.eCRUDMode) As List(Of ATM00400DTO)
End Interface
