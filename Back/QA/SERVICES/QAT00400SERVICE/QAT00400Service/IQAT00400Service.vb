Imports System.ServiceModel
Imports R_Common
Imports QAT00400Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00400Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00400Service

    Inherits R_IServicebase(Of QAT00400DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransProfile(ByVal poPar As QAT00400DTO) As QAT00400RSPGetTransProfileDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLoadQAParameter(ByVal poPar As QAT00400DTO) As QAT00400DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckDocument(ByVal poPar As QAT00400DTO) As QAT00400DTO


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocumentInfo(ByVal poPar As QAT00400DTO) As QAT00400DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getVlidationSavemodenew(ByVal poPar As QAT00400DTO) As Integer

    '===== MT 20170831 ====='
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckRelatedDocument(ByVal poPar As QAT00400DTO) As Integer

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub redraftProcess(poParam As QAT00400DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub submitProcess(poParam As QAT00400DTO)
    '======================='

End Interface
