Imports System.ServiceModel
Imports R_Common
Imports PYM01200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01200TransferHeaderService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01200TransferHeaderService
    Inherits R_IServicebase(Of PYM01200TransferHeaderDTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Function getBankNumber(poParam As PYM01200TransferHeaderDTO) As PYM01200TransferHeaderDTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGsmCashBank(poParam As PYM01200BankAccountDTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getGsmCurrency(poParam As PYM01200BankAccountDTO) As Boolean

End Interface
