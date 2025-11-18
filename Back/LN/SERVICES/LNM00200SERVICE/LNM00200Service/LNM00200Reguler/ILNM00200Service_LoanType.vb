Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNM00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00200Service_LoanType" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00200Service_LoanType
    Inherits R_IServicebase(Of LNM00200Dto)

    '<OperationContract()>
    '     <FaultContract(GetType(R_ServiceExceptions))> _
    'Function QueryTester(pcParam As String) As List(Of LNM00200Dto)
End Interface
