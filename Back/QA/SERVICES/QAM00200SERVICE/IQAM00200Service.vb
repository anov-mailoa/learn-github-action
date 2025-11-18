Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAM00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00200Service
    Inherits R_IServicebase(Of QAM00200DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub updateStatus(poParam As QAM00200DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_DOCTYPE_ALREADYUSED(poParam As QAM00200DTO) As Integer

End Interface
