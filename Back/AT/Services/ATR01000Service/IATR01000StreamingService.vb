Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR01000Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01000StreamingService" in both code and config file together.

<ServiceContract()>
Public Interface IATR01000StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

    <OperationContract(Action:="getReason", ReplyAction:="getReason")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReason() As Message

    <OperationContract(Action:="GetDataExcel", ReplyAction:="GetDataExcel")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function GetDataExcel() As Message


End Interface
