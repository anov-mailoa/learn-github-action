Imports System.ServiceModel
Imports ATM00600Back
Imports R_Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00620WorkGroupService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00620WorkGroupService

    Inherits R_IServicebase(Of ATM00620WorkGroupDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub CopyToProcess(ByVal poParam As ATM00620WorkGroupDTO)


End Interface
