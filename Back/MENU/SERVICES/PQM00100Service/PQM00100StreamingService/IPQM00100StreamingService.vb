Imports System.ServiceModel
Imports R_Common
Imports PQM00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPQM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPQM00100StreamingService

    <OperationContract(Action:="getListData", ReplyAction:="getListData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListData() As Message

End Interface
