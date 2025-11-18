Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00800ByEmpStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00800ByEmpStreamingService

    <OperationContract(Action:="getAttCorrectionByEmp", ReplyAction:="getAttCorrectionByEmp")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getAttCorrectionByEmp() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of ATT00800ByEmpStreamDTO),
              ByVal poParam2 As List(Of ATT00800ByEmpRegDTO))

End Interface
