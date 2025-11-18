Imports R_BackEnd
Imports R_Common
Imports MCB02100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

<ServiceContract()>
Public Interface IMCB02100StreamingService

    <OperationContract(action:="getTransferBankDocumentList", ReplyAction:="getTransferBankDocumentList")> _
                 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransferBankDocumentList() As Message

    <OperationContract(action:="getGenerateFile", ReplyAction:="getGenerateFile")> _
                 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGenerateFile() As Message

    <OperationContract(action:="getRSPBANKTRANSFERCLAIMTITLE", ReplyAction:="getRSPBANKTRANSFERCLAIMTITLE")> _
                 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRSPBANKTRANSFERCLAIMTITLE() As Message

    <OperationContract(action:="getFileExtension", ReplyAction:="getFileExtension")> _
                 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFileExtension() As Message

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid As List(Of MCB02100TransferBankDetailDto))

End Interface
