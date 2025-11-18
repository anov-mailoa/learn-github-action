Imports System.ServiceModel
Imports R_Common
Imports GSM00700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00700StreamingService

    <OperationContract(Action:="getListGeography", ReplyAction:="getListGeography")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGeography() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of GSM00700TreeDTO))

End Interface
