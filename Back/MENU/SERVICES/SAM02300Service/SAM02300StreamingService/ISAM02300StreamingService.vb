Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports SAM02300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02300StreamingService

    <OperationContract(Action:="GetReportList", ReplyAction:="GetReportList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportList() As Message

    <OperationContract(Action:="GetByteFile", ReplyAction:="GetByteFile")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetByteFile() As Message
End Interface
