Imports System.ServiceModel
Imports R_Common
Imports GSM01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01100StreamingService

    <OperationContract(Action:="getMasterBank", ReplyAction:="getMasterBank")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMasterBank() As Message

    <OperationContract(Action:="getCompanyBank", ReplyAction:="getCompanyBank")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompanyBank() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of GSM01100BankGridDTO))

End Interface
