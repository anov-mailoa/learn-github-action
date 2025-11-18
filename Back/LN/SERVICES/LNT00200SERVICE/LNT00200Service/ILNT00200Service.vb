Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00200Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00200Service
    Inherits R_IServicebase(Of LNT00200Dto)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As LNT00200Dto) As LNT00200Dto
End Interface
