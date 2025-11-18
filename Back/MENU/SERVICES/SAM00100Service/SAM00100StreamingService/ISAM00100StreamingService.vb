Imports System.ServiceModel
Imports R_Common
Imports SAM00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM0100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM00100StreamingService

    <OperationContract(Action:="getCurrList", ReplyAction:="getCurrList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrList() As Message

    <OperationContract(Action:="getListRateType", ReplyAction:="getListRateType")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListRateType() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of SAM00100GridDTO), poPar2 As List(Of SAM00110GridDTO))
End Interface
