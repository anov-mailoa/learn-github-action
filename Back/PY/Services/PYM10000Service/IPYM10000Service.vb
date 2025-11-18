Imports System.ServiceModel
Imports R_Common
Imports PYM10000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM10000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM10000Service
    Inherits R_IServicebase(Of PYM10000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub init(poParam As PYM10000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcSyntax As String)

End Interface
