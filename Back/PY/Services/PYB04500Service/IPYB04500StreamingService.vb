Imports System.ServiceModel
Imports R_Common
Imports PYB04500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM04500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB04500StreamingService

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYB04500Dto))

    <OperationContract(Action:="GetGvSalaryProcess", ReplyAction:="GetGvSalaryProcess")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvSalaryProcess() As Message

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Get_ProcessPeriod(poParam As PYB04500Dto) As String

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function cekMultiCompany(pcCompId As String) As PYB04500Dto

End Interface
