Imports System.ServiceModel
Imports R_Common
Imports EST10000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEST10000FamilyService" in both code and config file together.
<ServiceContract()>
Public Interface IEST10000FamilyService
    Inherits R_IServicebase(Of EST10000FamilyDataDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ApprovalFamilyData(poParam As EST10000FamilyDataDTO)
End Interface
