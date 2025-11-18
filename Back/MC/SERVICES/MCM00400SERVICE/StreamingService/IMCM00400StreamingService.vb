Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports MCM00400Back

<ServiceContract()>
Public Interface IMCM00400StreamingService
    <OperationContract(Action:="getMCM00400list", ReplyAction:="getMCM00400list")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMCM00400list() As Message

End Interface
