Imports System.ServiceModel
Imports R_Common
Imports PYT00100Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00100EmployeeService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00100EmployeeService

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkDetail(poParam As PYT00100EmployeeDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub CheckIfExistUpload(poParam As PYT00100EmployeeDTO)
End Interface
