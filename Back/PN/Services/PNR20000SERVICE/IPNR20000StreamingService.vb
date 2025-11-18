Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR20000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR20000StreamingService
    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getReportHeaderData", ReplyAction:="getReportHeaderData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportHeaderData() As Message

    <OperationContract(Action:="getListComboBox", ReplyAction:="getListComboBox")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListComboBox() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub dummy(poParam As PNR20000DTO)
End Interface
