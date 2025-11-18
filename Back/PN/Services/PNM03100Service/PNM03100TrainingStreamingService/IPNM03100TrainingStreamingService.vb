Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100TrainingStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100TrainingStreamingService

    <OperationContract(Action:="getlReqRecurring", ReplyAction:="getlReqRecurring")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getlReqRecurring() As Message

    <OperationContract(Action:="getTraining", ReplyAction:="getTraining")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTraining() As Message

End Interface
