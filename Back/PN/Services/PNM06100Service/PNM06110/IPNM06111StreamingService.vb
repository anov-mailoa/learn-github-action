Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM06111StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM06111StreamingService

    <OperationContract(Action:="GetLetterNumber", ReplyAction:="GetLetterNumber")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLetterNumber() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poGrid As List(Of PNM06110NumberGridDTO))

End Interface
