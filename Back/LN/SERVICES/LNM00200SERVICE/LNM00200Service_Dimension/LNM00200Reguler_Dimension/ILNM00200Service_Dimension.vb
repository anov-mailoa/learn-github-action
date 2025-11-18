Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNM00200Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00201Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00200Service_Dimension
    Inherits R_IServicebase(Of LNM00200Dto_Dimension)

    <OperationContract()>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidate(pcCompId As String, pcLoanType As String) As Integer

    <OperationContract()>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_Build_Loan_Policy_Matrix(poParam As LNM00200Dto_Dimension)
End Interface
