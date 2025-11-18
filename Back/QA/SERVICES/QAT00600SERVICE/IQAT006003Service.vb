Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT006003Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT006003Service
    Inherits R_IServicebase(Of QAT006003DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub deleteAttProc(ByVal poParam As QAT006003DTO)
End Interface
