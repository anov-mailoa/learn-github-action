Imports System.ServiceModel
Imports R_Common
Imports GSM00400Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM0410StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00410StreamingService

    <OperationContract(Action:="checkCenterDB", ReplyAction:="checkCenterDB")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkCenterDB() As Message

    '<OperationContract(Action:="SaveBatch", ReplyAction:="SaveBatch")> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Sub SaveBatch()

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of GSM00400DTO))

End Interface
