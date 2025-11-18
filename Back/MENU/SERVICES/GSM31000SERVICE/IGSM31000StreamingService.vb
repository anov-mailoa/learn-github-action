Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM31000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM31000StreamingService

    <OperationContract(Action:="GetHistoryList", ReplyAction:="GetHistoryList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHistoryList() As Message

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of GSM31000Back.GSM31000DTO))

End Interface
