Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR03000Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR03000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR03000StreamingService

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParReguler As System.Collections.Generic.List(Of ATR03000DTO))

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetData() As Message

End Interface
