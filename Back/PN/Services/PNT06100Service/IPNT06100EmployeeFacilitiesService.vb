Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports PNT06100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06100EmployeeFacilitiesService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06100EmployeeFacilitiesService
    Inherits R_IServicebase(Of PNT06100AssignmentHdDto)

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNT06100AssignmentHdDto) As PNT06100AssignmentHdDto

End Interface
