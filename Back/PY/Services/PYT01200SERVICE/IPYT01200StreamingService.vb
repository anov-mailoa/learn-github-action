Imports System.ServiceModel
Imports R_Common
Imports PYT01200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT01200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT01200StreamingService

    <OperationContract(Action:="getTrxList", ReplyAction:="getTrxList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTrxList() As Message

    <OperationContract(Action:="getYearList", ReplyAction:="getYearList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getYearList() As Message

    <OperationContract(Action:="getEmpList", ReplyAction:="getEmpList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpList() As Message

    <OperationContract(Action:="getDetailList", ReplyAction:="getDetailList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailList() As Message

    <OperationContract(Action:="getCompList", ReplyAction:="getCompList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompList() As Message

    <OperationContract(Action:="getCmbProcessCode", ReplyAction:="getCmbProcessCode")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbProcessCode() As Message

End Interface
