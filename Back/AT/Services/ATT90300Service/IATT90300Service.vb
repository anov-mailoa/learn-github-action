Imports System.ServiceModel
Imports R_Common
Imports ATT90300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90300Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90300Service
    Inherits R_IServicebase(Of ATT90300Dto)
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionProfile(ByVal poParam As ATT90300Dto) As ATT90300Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitOrDraft(ByVal poParam As ATT90300Dto)
End Interface
