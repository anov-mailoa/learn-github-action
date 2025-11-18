Imports System.ServiceModel
Imports R_Common
Imports ESM00400Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00400Service
    Inherits R_IServicebase(Of ESM00400DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getESSMembershipStatus(pcCompId As String) As ESM00400DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub deleteEmpAttLocation(poParam As ESM00400DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub resetUserApproval(poParam As ESM00400DTO)
End Interface
