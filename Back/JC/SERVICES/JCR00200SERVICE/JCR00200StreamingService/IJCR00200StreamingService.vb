Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCR00200Back
Imports JCR00200Common
Imports System.ServiceModel.Channels



' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCR00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCR00200StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract(Action:="GetDataGrid", ReplyAction:="GetDataGrid")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDataGrid() As Message

    <OperationContract(Action:="GetDataCompetency", ReplyAction:="GetDataCompetency")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDataCompetency() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParTenor As System.Collections.Generic.List(Of JCR00200DTO))


End Interface
