Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT07250Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07250StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07250StreamingService

    <OperationContract(Action:="getPnmGradeDt", ReplyAction:="getPnmGradeDt")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmGradeDt() As Message

End Interface
