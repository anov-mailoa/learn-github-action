Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00500TransactionService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00500TransactionService
    Inherits R_IServicebase(Of ATT00500TransactionDTO)

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionProfileRtn(poParam As ATT00500TransactionDTO) As ATT00500TransactionDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function changeDraftUndraft(poParam As ATT00500TransactionDTO) As ATT00500TransactionDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As ATT00500TransactionDTO) As ATT00500TransactionDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As ATT00500TransactionDTO) As ATT00500TransactionDTO

End Interface
