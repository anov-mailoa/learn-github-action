Imports System.ServiceModel
Imports R_Common
Imports PYM01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01100Service

    Inherits R_IServicebase(Of PYM01100DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub CheckSyntax(pcCompId As String, pcSyntax As String)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkFormulaUsage(poParam As PYM01100DTO) As Boolean

End Interface
