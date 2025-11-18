Imports System.ServiceModel
Imports R_Common
Imports MCM02000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM02000Service
    Inherits R_IServicebase(Of MCM02000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub getCheckSyntax(pcSyntax As String, plFilter As Boolean)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveFullNameParam(poParam As List(Of MCM02000GridDTO))

End Interface
