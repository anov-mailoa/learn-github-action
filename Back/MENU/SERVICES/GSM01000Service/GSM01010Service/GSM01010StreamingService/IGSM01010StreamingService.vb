Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01010StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01010StreamingService

    <OperationContract(Action:="getDataGridTransNum", ReplyAction:="getDataGridTransNum")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataGridTransNum() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of GSM01010DocNumGridDTO))

End Interface
