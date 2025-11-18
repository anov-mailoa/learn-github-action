Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports PNT06200Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06200EmployeeFacilitiesServices" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06200EmployeeFacilitiesServices
    Inherits R_IServicebase(Of PNT06200ReturnHdDto)


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNT06200ReturnHdDto) As PNT06200ReturnHdDto

End Interface
