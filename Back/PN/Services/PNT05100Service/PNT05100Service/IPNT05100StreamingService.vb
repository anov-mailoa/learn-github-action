Imports System.ServiceModel
Imports R_Common
Imports PNT05100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT05100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT05100StreamingService

    <OperationContract(Action:="getCmbPosition", ReplyAction:="getCmbPosition")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPosition() As Message

End Interface
