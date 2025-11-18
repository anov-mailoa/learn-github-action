Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYM01300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01300Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01300Service

    Inherits R_IServicebase(Of PYM01300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcSyntax As String)


End Interface
