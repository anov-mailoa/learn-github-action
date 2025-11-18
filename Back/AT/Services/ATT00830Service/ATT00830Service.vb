Imports R_BackEnd
Imports R_Common
Imports ATT00830Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports ATT00100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00830Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00830Service
    Inherits R_IServicebase(Of ATT00830DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poCurrent As ATT00830DTO) As ATT00830DTO

End Interface
