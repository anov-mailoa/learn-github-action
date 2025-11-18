Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ESM01200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01200Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM01200LeaveService
    Inherits R_IServicebase(Of ESM01200LeaveDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSumLeaveBalance(poParam As ESM01200LeaveDTO) As ESM01200LeaveDTO

End Interface
