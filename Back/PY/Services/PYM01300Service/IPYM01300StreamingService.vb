Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYM01300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01300StreamingService

    <OperationContract(Action:="NemObjekPajak", ReplyAction:="NemObjekPajak")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getNemObjekPajak() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParamGrid As System.Collections.Generic.List(Of PYM01300GridDTO))

End Interface
