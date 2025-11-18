Imports System.ServiceModel
Imports R_Common
Imports SAM02900Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02900Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02900Service

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function EditMFA(poEntity As EditMfaDTO) As MfaDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetSecurityMFA(pcCompanyId As String) As MfaDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub CheckMfaData(pcCompanyId As String)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetMFAMode() As List(Of MfaModeDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetNonMFAUser(poEntity As MFAUserParameterDTO) As MFAUserDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function SaveNonMFAUser(poEntity As SaveNonMFAUserDTO) As MFAUserDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub DeleteNonMFAUser(poEntity As MFAUserParameterDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetSecurityOnSite(pcCompanyId As String) As OnSiteDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function EditOnSite(poEntity As OnSiteDTO) As OnSiteDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub CheckOnSiteData(pcCompanyId As String)
End Interface
