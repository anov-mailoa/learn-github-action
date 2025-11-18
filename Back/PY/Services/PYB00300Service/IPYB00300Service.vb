Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYB00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00300Service

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEndPeriod(poParam As PYB00300DTO) As String

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub cekProsesGaji(poParam As PYB00300DTO)


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSalaryGroup(poParam As PYB00300DTO) As PYB00300DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPayrollSytemParameter(pcCompId As String) As Integer

End Interface
