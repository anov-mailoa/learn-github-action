Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR03100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR03100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR03100StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getLegend", ReplyAction:="getLegend")>
     <FaultContract(GetType(R_ServiceExceptions))>
    Function getLegend() As Message

End Interface
