Imports System.ServiceModel
Imports R_Common
Imports GSM00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00500Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00500Service
    Inherits R_IServicebase(Of GSM00500DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckLevelChild(poParam As GSM00500DTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ActivateProcess(poParam As GSM00500DTO) As GSM00500DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub InitializeDepartment(pcCompId As String, pcUserId As String)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckLoad(pcCompId As String) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_GSM_DEPARTMENT_MOVE_DEPARTMENT(poParam As GSM00500DTO) As GSM00500DTO


End Interface
