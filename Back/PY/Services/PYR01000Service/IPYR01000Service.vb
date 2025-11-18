Imports System.ServiceModel
Imports R_Common
Imports PYR01000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYR01000Service
    Inherits R_IServicebase(Of PYR01000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub init(poParam As PYR01000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcSyntax As String)

End Interface
