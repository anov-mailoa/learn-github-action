Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00050Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00050Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00050Service
    Inherits R_IServicebase(Of ATT00050DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As ATT00050DTO) As ATT00050DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As ATT00050DTO) As ATT00050DTO

End Interface
