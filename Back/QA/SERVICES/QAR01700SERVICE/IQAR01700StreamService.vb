Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01700StreamService

    <OperationContract(Action:="QAR01700GetDat", ReplyAction:="QAR01700GetDat")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function QAR01700GetDat() As Message

    <OperationContract(Action:="QAR01700GetRepDat", ReplyAction:="QAR01700GetRepDat")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function QAR01700GetRepDat() As Message

End Interface
