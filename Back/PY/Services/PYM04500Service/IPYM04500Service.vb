Imports System.ServiceModel
Imports R_Common
Imports PYM04500Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM04500Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM04500Service
    Inherits R_IServicebase(Of PYM04500DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcSyntax As String, plFilter As Boolean)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveFullNameParam(poParam As List(Of PYM04500GridDTO))

End Interface
