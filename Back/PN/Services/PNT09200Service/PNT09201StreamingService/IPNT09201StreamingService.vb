Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT09200Back

<ServiceContract()>
Public Interface IPNT09201StreamingService

    <OperationContract(Action:="getAppreciationList", ReplyAction:="getAppreciationList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getAppreciationList() As Message

End Interface
