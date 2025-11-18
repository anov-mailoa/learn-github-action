Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB02000GenerateTransferFileService" in both code and config file together.
<ServiceContract()>
Public Interface IMCB02100GenerateTransferFileService
    Inherits R_IServicebase(Of MCB02100TransferBankDocumentDto)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrentMedicalYear(poParam As MCB02100TransferBankDocumentDto) As MCB02100TransferBankDocumentDto

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getInit(poParam As String) As Boolean
End Interface
