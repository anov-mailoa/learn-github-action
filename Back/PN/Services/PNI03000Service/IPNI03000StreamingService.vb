Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNI03000Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNI03000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNI03000StreamingService

    <OperationContract(Action:="getOutstanding", ReplyAction:="getOutstanding")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getOutstanding() As Message

End Interface
