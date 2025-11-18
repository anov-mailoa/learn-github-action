Imports System.ServiceModel
Imports R_Common
Imports ATT00600Back
Imports ATT00600Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00600Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00600Service

    Inherits R_IServicebase(Of ATT00600DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As ATT00600DTO) As ATT00600DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As ATT00600DTO) As ATT00600DTO

End Interface
