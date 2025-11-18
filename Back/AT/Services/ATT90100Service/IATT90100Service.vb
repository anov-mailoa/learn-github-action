Imports System.ServiceModel
Imports R_Common
Imports ATT90100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90100Service
    Inherits R_IServicebase(Of ATT90100Dto)
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionProfile(ByVal poParam As ATT90100Dto) As ATT90100Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitOrDraft(ByVal poParam As ATT90100Dto)
End Interface
