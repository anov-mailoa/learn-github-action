Imports System.ServiceModel
Imports R_Common
Imports ATM00600Back
Imports R_BackEnd
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00610SPService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00610ShiftPatternService
    Inherits R_IServicebase(Of ATM00610ShiftPatternDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkINO_USED_MNT(poParam As ATM00610ShiftPatternDTO) As Integer

End Interface
