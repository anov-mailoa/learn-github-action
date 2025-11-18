Imports System.ServiceModel
Imports R_Common
Imports ATT90800Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90800Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90800Service
    Inherits R_IServicebase(Of ATT90800Dto)
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionProfile(ByVal poParam As ATT90800Dto) As ATT90800Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitOrDraft(ByVal poParam As ATT90800Dto)
End Interface
