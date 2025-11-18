Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNM00100Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00100Service_Tenor" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00100Service_Tenor
    Inherits R_IServicebase(Of LNM00100DtoTenor)

    <OperationContract()>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDataTenor(ByVal pcComId As String, ByVal cLoanType As String, ByVal cRangeCode As String) As LNM00100DtoTenor

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function MaxTerm(pcLoanType As String) As Integer

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetValidation(ByVal poParam As LNM00100DtoTenor) As LNM00100DtoTenor

End Interface
