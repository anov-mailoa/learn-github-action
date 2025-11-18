Imports System.ServiceModel
Imports R_Common
Imports PYM08100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM08100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM08100Service
    Inherits R_IServicebase(Of PYM08100DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLastSeq(pcCompId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(plBreakToEmpLvl As Boolean, pcSyntax As String, plFilterFormula As Boolean)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveFullNameParam(poParam As List(Of PYM08100GridDTO))

End Interface
