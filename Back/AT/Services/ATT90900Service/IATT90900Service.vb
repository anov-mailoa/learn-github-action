Imports System.ServiceModel
Imports R_Common
Imports ATT90900Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90900Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90900Service
    Inherits R_IServicebase(Of ATT90900Dto)
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionProfile(ByVal poParam As ATT90900Dto) As ATT90900Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitOrDraft(ByVal poParam As ATT90900Dto)
End Interface
