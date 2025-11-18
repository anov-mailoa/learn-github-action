Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ATM00600Back
Imports ATM00620Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00600StreamingService

    <OperationContract(Action:="AmbilDatas", ReplyAction:="AmbilDatas")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListATM00600() As Message

    <OperationContract(Action:="StreamShiftPattern", ReplyAction:="StreamShiftPattern")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListATMPatternShift() As Message

    <OperationContract(Action:="StreamPatternSeq", ReplyAction:="StreamPatternSeq")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListATMPatternSeq() As Message

    <OperationContract(Action:="getDetail", ReplyAction:="getDetail")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetail() As Message

    <OperationContract(Action:="getMasterWorkTable", ReplyAction:="getMasterWorkTable")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMasterWorkTable() As Message

    <OperationContract(Action:="GetResultPreviewProcess", ReplyAction:="GetResultPreviewProcess")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetResultPreviewProcess() As Message

    <OperationContract(Action:="getDataProcess", ReplyAction:="getDataProcess")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataProcess() As Message

    <OperationContract(Action:="getScheduleRGB", ReplyAction:="getScheduleRGB")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getScheduleRGB() As Message

    <OperationContract(Action:="getHoliday", ReplyAction:="getHoliday")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getHoliday() As Message

    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParReguler As System.Collections.Generic.List(Of ATM00610RegulerShiftPatternDTO))

    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy1(ByVal poParReguler As System.Collections.Generic.List(Of ATM00600REGULERDTO))

    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy2(ByVal poParReguler As System.Collections.Generic.List(Of ATM00610RegulerPatternSeqDTO))
     
    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy4(ByRef poPar2 As List(Of ATM00620WorkGroupRegDTO))



End Interface
