Imports System.ServiceModel
Imports R_Common
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00100StructuralService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00100StructuralService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetApprovalCode(poParam As ESM00100StructuralDTO) As String

End Interface
