Imports System.ServiceModel
Imports R_Common
Imports PYM01500Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01500ServiceRef" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01500Service
    Inherits R_IServicebase(Of PYM01500DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLastYear(poParam As String) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcSyntax As String)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub cloneProcess(poParam As PYM01500DTO)

End Interface
