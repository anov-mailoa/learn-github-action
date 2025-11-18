Imports System.ServiceModel
Imports R_Common
Imports ATM12000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM12000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM12000StreamingService

    <OperationContract(Action:="getMaintainableReportList", ReplyAction:="getMaintainableReportList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMaintainableReportList() As Message

    <OperationContract(Action:="getDetailCellList", ReplyAction:="getDetailCellList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailCellList() As Message


End Interface
