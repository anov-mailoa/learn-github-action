Imports System.ServiceModel
Imports R_Common
Imports PYM00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00300Service
    Inherits R_IServicebase(Of PYM00300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcCompId As String, pcFormula As String, plIsFilter As Boolean)

End Interface
