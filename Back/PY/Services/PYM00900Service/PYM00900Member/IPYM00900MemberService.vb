Imports System.ServiceModel
Imports R_Common
Imports PYM00900Back
Imports R_BackEnd
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00900MemberService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00900MemberService
    Inherits R_IServicebase(Of PYM00900MemberDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub assignMember(poParam As PYM00900MemberDTO)

End Interface
