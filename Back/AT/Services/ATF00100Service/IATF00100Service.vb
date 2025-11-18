Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATF00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATF00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATF00100Service
    Inherits R_IServicebase(Of ATF00100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DeleteValidation(ByVal poParam As ATF00100DTO) As ATF00100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteSection(ByVal poParam As ATF00100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function BatchValidation(ByVal poParam As ATF00100DTO) As ATF00100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DeleteBatchValidation(ByVal poParam As ATF00100DTO) As ATF00100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteBatchSection(ByVal poParam As ATF00100DTO)
End Interface
