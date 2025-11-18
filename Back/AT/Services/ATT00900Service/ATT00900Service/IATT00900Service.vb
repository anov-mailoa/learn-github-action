Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00900BACK
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00900Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00900Service
    Inherits R_IServicebase(Of ATT00900DTO)


    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As ATT00900DTO) As ATT00900DTO

End Interface
