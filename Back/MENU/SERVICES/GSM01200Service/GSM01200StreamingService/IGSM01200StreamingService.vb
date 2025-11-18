Imports System.ServiceModel
Imports R_Common
Imports GSM01200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01200StreamingService

    <OperationContract(Action:="getGridCurr", ReplyAction:="getGridCurr")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridCurr() As Message

    <OperationContract(Action:="getGridRate", ReplyAction:="getGridRate")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridRate() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of GSM01200GridCurrDTO),
              ByVal poPar2 As List(Of GSM01200GridRateDTO))

End Interface
