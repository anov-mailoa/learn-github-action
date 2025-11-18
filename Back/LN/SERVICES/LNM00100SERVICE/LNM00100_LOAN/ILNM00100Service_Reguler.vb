Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00300Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00100Service_Reguler

    Inherits R_IServicebase(Of LNM00100Dto)

    <OperationContract()>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataLogin(ByVal pcCoid As String) As LNM00100Dto

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataLoan(ByVal pcCoid As String) As LNM00100Dto

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub InsertNullData(ByVal poParam As LNM00100Dto)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidateAuthority(ByVal poParam As LNM00100Dto) As Integer
End Interface