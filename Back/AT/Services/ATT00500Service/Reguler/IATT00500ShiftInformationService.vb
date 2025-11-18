Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00500ShiftInformationService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00500ShiftInformationService
    Inherits R_IServicebase(Of ATT00500ShiftInformationDTO)
    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getShiftInformation(poParameter As ATT00500ShiftInformationDTO) As ATT00500ShiftInformationDTO
End Interface
