Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel
Imports PNM05200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05200PersonalBankService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05200PersonalBankService
    Inherits R_IServicebase(Of PNM05200PersonalBankDTO)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCashBank(poParam As PNM05200PersonalBankDTO) As List(Of ComboBoxDTO)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrency(poParam As PNM05200PersonalBankDTO) As List(Of ComboBoxDTO)

End Interface
