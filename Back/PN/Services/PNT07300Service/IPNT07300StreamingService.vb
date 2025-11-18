Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT07300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07300StreamingService

    <OperationContract(Action:="getPnmGradeDt", ReplyAction:="getPnmGradeDt")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmGradeDt() As Message

    <OperationContract(Action:="getCompany", ReplyAction:="getCompany")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getCompany() As Message

End Interface
