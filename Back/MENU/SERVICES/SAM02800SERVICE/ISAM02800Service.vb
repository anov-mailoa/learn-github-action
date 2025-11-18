Imports R_BackEnd
Imports R_Common
Imports SAM02800Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02800Service
    Inherits R_IServicebase(Of SAM02800DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub AssignmentDashboardProcess(poEntity As AssignmentDashboardProcessDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub DeleteUserDashboard(poEntity As DeleteUserDashboardDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub EditUserDashboard(poEntity As EditUserDashboardDTO)
End Interface
