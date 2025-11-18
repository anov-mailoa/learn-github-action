Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCT01000Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT01000DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IJCT01000DetailService
       Inherits R_IServicebase(Of JCT01000DetailDto)
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ReopenProcess(poParam As JCT01000DetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeader(poParam As JCT01000DetailDto) As HeaderDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub RejectProcess(poParam As JCT01000DetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ResyncProcess(poParam As JCT01000DetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ReassignProcess(poParam As JCT01000DetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetJcSystemParam(pcCompId As String) As JCT01000DetailDto

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ProcessFileResult(poParam As JCT01000DetailDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function UpdateAttachmentFile(poParam As List(Of JCT01000DetailDto))
End Interface
