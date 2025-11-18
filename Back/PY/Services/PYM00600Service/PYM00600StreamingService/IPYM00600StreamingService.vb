Imports System.ServiceModel
Imports R_Common
Imports PYM00600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00600StreamingService

    <OperationContract(Action:="getProcess", ReplyAction:="getProcess")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProcess() As Message


End Interface
