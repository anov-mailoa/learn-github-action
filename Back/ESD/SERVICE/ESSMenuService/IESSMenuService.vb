Imports System.ServiceModel
Imports R_Common
Imports ESSMenuBack

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESSMenuService" in both code and config file together.
<ServiceContract()>
Public Interface IESSMenuService

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Login(ByVal poParam As ESSLoginDTO) As ESSLoginDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub SetKey(pcKey As String)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub R_UserLockingFlush(ByVal pcCurrentCompanyId As String, ByVal pcUserId As String)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetInfo() As List(Of AboutDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub UpdatePassword(poParam As ESSLoginDTO)
End Interface
