Imports System.ServiceModel
Imports R_Common
Imports PYM01600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01600StreamingService

    <OperationContract(Action:="getDenominationList", ReplyAction:="getDenominationList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDenominationList() As Message

    <OperationContract(Action:="getCurrencyList", ReplyAction:="getCurrencyList")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrencyList() As Message

End Interface
