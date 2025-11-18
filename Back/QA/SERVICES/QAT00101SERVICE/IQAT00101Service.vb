Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAT00101Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00101Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00101Service
    Inherits R_IServicebase(Of QAT00101DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getQaParameter(poParam As QAT00101DTO) As QAT00101DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function EnableDisableDocType(poParam As QAT00101DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function updateStatusConfirm(poParam As QAT00101DTO) As QAT00101DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function updateStatusRedraft(poParam As QAT00101DTO) As QAT00101DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function updateStatusUnverify(poParam As QAT00101DTO) As QAT00101DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function updateStatusVerify(poParam As QAT00101DTO) As QAT00101DTO
     
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function updateStatusSubmit(poParam As QAT00101DTO) As QAT00101DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function updateAll(poParam As QAT00101DTO) As QAT00101DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub submitValidation(poParam As QAT00101DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function updateStatusRevised(poParam As QAT00101DTO) As QAT00101DTO

End Interface
