Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB00200Back

<ServiceContract()>
Public Interface IMCB00200StreamingService

    <OperationContract(Action:="getMCB00200List", ReplyAction:="getMCB00200List")> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMCB00200List() As Message

End Interface
