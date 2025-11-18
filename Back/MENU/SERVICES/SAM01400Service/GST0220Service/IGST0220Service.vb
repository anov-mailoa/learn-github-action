Imports System.ServiceModel
Imports R_Common
Imports SAM01400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGST0220Service" in both code and config file together.
<ServiceContract()>
Public Interface IGST0220Service

    Inherits R_BackEnd.R_IServicebase(Of GST0220DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function svcGetUserExceptionList() As List(Of GST0220DTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function svcGetUserList() As List(Of GST0220UserDTO)

End Interface
