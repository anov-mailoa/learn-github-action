Imports System.ServiceModel
Imports R_Common
Imports PYB01500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB01500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB01500StreamingService

    <OperationContract(Action:="getKPPList", ReplyAction:="getKPPList")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getKPPList() As Message

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poDetail As List(Of PYB01500Dto), poDetail1 As List(Of PYB01500GridDto))

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAllGroupCode(pcCompanyId As String) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckFinalizeKpp(ByVal loParam As PYB01500Dto) As Boolean
End Interface
