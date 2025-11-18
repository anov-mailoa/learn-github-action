Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCM00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM00200Service

    Inherits R_IServicebase(Of MCM00200DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkMcmRuleDtItem(pcCompId As String, pcItemId As String) As MCM00200DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkMctClaimHd(pcCompId As String, pcItemId As String) As MCM00200DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getActive(poParam As MCM00200DTO) As MCM00200DTO

End Interface
