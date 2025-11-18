Imports System.ServiceModel
Imports R_Common
Imports GSM01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01030StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01030StreamingService

    <OperationContract(Action:="getTransParam", ReplyAction:="getTransParam")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransParam() As Message
 
End Interface
