Imports System.ServiceModel
Imports R_Common
Imports JCR00300Back
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCR00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCR00300StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message

    <OperationContract(Action:="GetDataGrid", ReplyAction:="GetDataGrid")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDataGrid() As Message

    <OperationContract(Action:="GetDataCompetency", ReplyAction:="GetDataCompetency")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDataCompetency() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParTenor As System.Collections.Generic.List(Of JCR00300DTO))

End Interface
