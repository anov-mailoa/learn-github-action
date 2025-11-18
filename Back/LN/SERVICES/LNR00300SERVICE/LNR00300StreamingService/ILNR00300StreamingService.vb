Imports System.ServiceModel
Imports R_Common
Imports LNR00300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00300StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReport() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParReguler As System.Collections.Generic.List(Of LNR00300Dto_R),
              poParReport As System.Collections.Generic.List(Of ReportHeaderDTO))

End Interface
