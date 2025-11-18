Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCT00200Back

<ServiceContract()>
Public Interface IMCT00200StreamingService

    <OperationContract(Action:="getOverLimitClaimlist", ReplyAction:="getOverLimitClaimlist")> _
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOverLimitClaimlist() As Message

    <OperationContract(Action:="getOverLimitTransactionList", ReplyAction:="getOverLimitTransactionList")> _
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOverLimitTransactionList() As Message


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid1 As List(Of MCT00200OverlimitClaimListDto))

End Interface
