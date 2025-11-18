Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT04100Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT04100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT04100StreamingService

    <OperationContract(Action:="getPnmGradeDt", ReplyAction:="getPnmGradeDt")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmGradeDt() As Message

End Interface
