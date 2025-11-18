Imports System.ServiceModel
Imports R_Common
Imports PYM01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01100StreamingService

    <OperationContract(Action:="getPymFormula", ReplyAction:="getPymFormula")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPymFormula() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParGrid As List(Of PYM01100GridDTO))

End Interface
