Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCT00200Back

<ServiceContract()>
Public Interface IMCT00200OverlimitClaimListService
    Inherits R_IServicebase(Of MCT00200OverlimitClaimDetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function saveOverlimitClaimList(poParam As MCT00200OverlimitClaimDetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function saveApproveClaimProcess(poParam As MCT00200OverlimitClaimDetailDto)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitSaveOverlimitTransaction(poParam As MCT00200OverlimitClaimDetailDto)


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSaveOverlimitTransaction(poParam As MCT00200OverlimitClaimDetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecordMedicalRestriction(poParam As MCT00200ApprovalClaimDto) As MCT00200ApprovalClaimDto

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekMedicalYear(pcCompId As String) As MCT00200OverlimitClaimDetailDto

End Interface
