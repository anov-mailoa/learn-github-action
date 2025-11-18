Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PNM14100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14100StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataGrid() As Message

    <OperationContract(Action:="getListBPJSPerusahaan", ReplyAction:="getListBPJSPerusahaan")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListBPJSPerusahaan() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParReguler As PNM14100Dto_R,
              ByVal poPar As System.Collections.Generic.List(Of PNM14500ParameterStreamingDTO))
End Interface
