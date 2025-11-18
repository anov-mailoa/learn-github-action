Imports System.ServiceModel
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAI00100Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAI00100Service

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCountHistory(pcCompanyId As String, pcTimeRange As String, pcUserId As String, pcProgram As String) As Integer

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteHistory(pcCompanyId As String, pcTimeRange As String, pcUserId As String, pcProgram As String)

End Interface
