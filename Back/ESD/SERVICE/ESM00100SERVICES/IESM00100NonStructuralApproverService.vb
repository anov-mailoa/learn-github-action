Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00100NonStructuralApproverService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00100NonStructuralApproverService
    Inherits R_IServicebase(Of ESM00100NonStructuralApproverDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub SavePositionSequence(poParam As List(Of ESM00100NonStructuralApproverDTO))

End Interface
