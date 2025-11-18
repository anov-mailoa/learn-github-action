Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100JobSpecStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100JobSpecStreamingService

    <OperationContract(Action:="getCmbCriteria", ReplyAction:="getCmbCriteria")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCriteria() As Message

    <OperationContract(Action:="getCmbCategory", ReplyAction:="getCmbCategory")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCategory() As Message

    <OperationContract(Action:="getCmbSingleValue", ReplyAction:="getCmbSingleValue")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSingleValue() As Message

    <OperationContract(Action:="getCmbSpecType", ReplyAction:="getCmbSpecType")>
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSpecType() As Message

    <OperationContract(Action:="getJobSpecHd", ReplyAction:="getJobSpecHd")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getJobSpecHd() As Message

    <OperationContract(Action:="getJobSpecDt", ReplyAction:="getJobSpecDt")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getJobSpecDt() As Message

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParPNM03100Streaming As System.Collections.Generic.List(Of PNM03100JobSpecHeaderDTO))

End Interface
