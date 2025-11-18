Imports System.ServiceModel
Imports ATM00100Back
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00100Service

    Inherits R_IServicebase(Of ATM00100DTO)

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function validationMaxBreakTimes(poParam As ATM00100DTO) As Boolean

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckWorkGroup(pcCompId) As Boolean

End Interface
