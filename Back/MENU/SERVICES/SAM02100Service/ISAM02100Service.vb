Imports System.ServiceModel
Imports R_Common
Imports SAM02100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02100Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02100Service

    Inherits R_IServicebase(Of SAM02100DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveData(poData As R_EmailEngineCommandPar, poParam As SAM02100DTO)

End Interface
