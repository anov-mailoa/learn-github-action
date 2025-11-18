Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM06100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM06100StreamingService

    <OperationContract(Action:="getLetterTemplate", ReplyAction:="getLetterTemplate")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLetterTemplate() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poGrid As List(Of PNM06100GridDTO))

End Interface
