Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports GSM01000Common
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01020Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01020Service

    Inherits R_IServicebase(Of GSM01020DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDept(poParam As GSM01020DTO) As List(Of GSM01020CmbDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMaxSeq(poParam As GSM01020DTO) As Integer

    <OperationContract()> _
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDepartmentDESC(poParam As GSM01020DTO) As String

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveApprovalSequence(poParam As List(Of GSM01020DTO))

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GSL00300DESC(poParam As GSM01020DTO) As GSM01020UserAppDTO

#Region "VALIDATION"
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekDeptMode(poParam As GSM01020DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekDeptSamUser(poParam As GSM01020DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekUserId(poParam As GSM01020DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekSequence(poParam As GSM01020DTO) As Boolean

#End Region

End Interface
