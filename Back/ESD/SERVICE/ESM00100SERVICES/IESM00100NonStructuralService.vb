Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00100NonStructuralService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00100NonStructuralService
    Inherits R_IServicebase(Of ESM00100NonStructuralDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub SaveApprovalCode(poParam As ESM00100NonStructuralDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteApprovalCode(poParam As ESM00100NonStructuralDTO)

End Interface
