Imports System.ServiceModel
Imports R_Common
Imports QAT00201Back
Imports R_BackEnd
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00201Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00201Service
    Inherits R_IServicebase(Of QAT00201DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionProfile(poParam As QAT00201DTO) As QAT00201DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getQAParam(poParam As QAT00201DTO) As QAT00201DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocumentInfoProcess(poParam As QAT00201DTO) As QAT00201DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub confirmProcess(poParam As QAT00201DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub redraftProcess(poParam As QAT00201DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub unverifyProcess(poParam As QAT00201DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub verifyProcess(poParam As QAT00201DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub submitProcess(poParam As QAT00201DTO)

End Interface
