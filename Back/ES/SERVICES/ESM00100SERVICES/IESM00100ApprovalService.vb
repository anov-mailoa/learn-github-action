Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00100ApprovalService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00100ApprovalService
    Inherits R_IServicebase(Of ESM00100ApprovalDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckApprovalSetting(poParam As ESM00100ApprovalDTO) As Boolean

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub CopyToProcess(loParam As ESM00100ApprovalDTO)
End Interface
