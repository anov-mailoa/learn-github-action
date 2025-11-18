Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR02100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR02100StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message
  
End Interface
