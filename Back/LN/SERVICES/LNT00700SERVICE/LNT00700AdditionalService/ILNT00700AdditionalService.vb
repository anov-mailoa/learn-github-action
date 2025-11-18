Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00700AdditionalService" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00700AdditionalService
    Inherits R_IServicebase(Of LNT00700AdditionalDto)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As LNT00700AdditionalDto) As LNT00700AdditionalDto


    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As LNT00700AdditionalDto) As LNT00700AdditionalDto
End Interface
