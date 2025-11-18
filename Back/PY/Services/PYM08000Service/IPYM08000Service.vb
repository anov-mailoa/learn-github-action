Imports System.ServiceModel
Imports R_Common
Imports PYM08000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM08000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM08000Service
    Inherits R_IServicebase(Of PYM08000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLastSeq(pcCompId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcCompId As String, pcSyntax As String)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveFullNameParam(poParam As List(Of PYM08000DTO))

End Interface
