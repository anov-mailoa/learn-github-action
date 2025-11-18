Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00600Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00620WorkGroupEmpService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00620WorkGroupEmpService

    Inherits R_IServicebase(Of ATM00620WorkGroupEmpDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DeleteValidation(ByVal poParam As ATM00620WorkGroupEmpDTO) As ATM00620WorkGroupEmpDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteSection(ByVal poParam As ATM00620WorkGroupEmpDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function BatchValidation(ByVal poParam As ATM00620WorkGroupEmpDTO) As ATM00620WorkGroupEmpDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DeleteBatchValidation(ByVal poParam As ATM00620WorkGroupEmpDTO) As ATM00620WorkGroupEmpDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteBatchSection(ByVal poParam As ATM00620WorkGroupEmpDTO)

End Interface
