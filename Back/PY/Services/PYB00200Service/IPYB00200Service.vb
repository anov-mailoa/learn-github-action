Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYB00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00200Service

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkEmpBankTransfer(poParam As PYB00200Grid_R) As Integer

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetSingleSalaryProcess(poParam As PYB00200Dto) As PYB00200Grid_R

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function checkValidasiWarning(poParam As PYB00200Grid_R) As String

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSingleResignSalaryProcess(poParam As PYB00200Dto) As PYB00200Dto


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub cancelExtendResign(poParam As PYB00200Dto)

End Interface
