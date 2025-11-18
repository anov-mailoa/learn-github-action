Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCT09100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT09100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT09100StreamingService
    <OperationContract(Action:="getListGrid", ReplyAction:="getListGrid")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getListGrid() As Message


End Interface
