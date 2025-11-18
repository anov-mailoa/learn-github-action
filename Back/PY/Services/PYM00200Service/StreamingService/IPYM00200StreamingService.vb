Imports R_BackEnd
Imports R_Common
Imports PYM00200Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

<ServiceContract()>
Public Interface IPYM00200StreamingService

    <OperationContract(Action:="GetPYM00200List", ReplyAction:="GetPYM00200List")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetPYM00200List() As Message

    <OperationContract(Action:="GetPYM00210List", ReplyAction:="GetPYM00210List")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetPYM00210List() As Message

End Interface
