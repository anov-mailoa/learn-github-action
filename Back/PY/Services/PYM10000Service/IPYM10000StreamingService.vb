Imports System.ServiceModel
Imports R_Common
Imports PYM10000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM10000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM10000StreamingService

    <OperationContract(Action:="getCustomReportList", ReplyAction:="getCustomReportList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCustomReportList() As Message

    <OperationContract(Action:="getCustomReportCellList", ReplyAction:="getCustomReportCellList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCustomReportCellList() As Message


End Interface
