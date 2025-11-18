Imports System.ServiceModel
Imports R_Common
Imports EST10000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEST10000EmergencyContactService" in both code and config file together.
<ServiceContract()>
Public Interface IEST10000EmergencyContactService
    Inherits R_IServicebase(Of EST10000EmergencyDataDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ApprovalEmergencyData(poParam As EST10000EmergencyDataDTO)
End Interface
