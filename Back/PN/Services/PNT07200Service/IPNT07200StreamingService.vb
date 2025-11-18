Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT07200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07200StreamingService

    <OperationContract(Action:="getPnmGradeDt", ReplyAction:="getPnmGradeDt")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmGradeDt() As Message

End Interface
