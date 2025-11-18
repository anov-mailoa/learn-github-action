Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB02000GenerateTransferFileService" in both code and config file together.
<ServiceContract()>
Public Interface IMCB02000GenerateTransferFileService
    Inherits R_IServicebase(Of MCB02000TransferBankDocumentDto)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrentMedicalYear(poParam As MCB02000TransferBankDocumentDto) As MCB02000TransferBankDocumentDto

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getInit(poParam As String) As Boolean
End Interface
