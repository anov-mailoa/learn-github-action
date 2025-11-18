Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00500StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00500StreamService

    <OperationContract(Action:="StreamTransactionList", ReplyAction:="StreamTransactionList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionList() As Message

    <OperationContract(Action:="StreamEmployeeList", ReplyAction:="StreamEmployeeList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeList() As Message

    <OperationContract(Action:="StreamMultipleList", ReplyAction:="StreamMultipleList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMultipleEmployeeList() As Message

    <OperationContract(Action:="StreamFacilityList", ReplyAction:="StreamFacilityList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListFacility() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500TransactionStreamDTO),
              ByVal poParEmployeeStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500EmployeeStreamDTO),
              ByVal poParFacilityStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500FacilityStreamDTO),
              ByVal poHeaderGrid As System.Collections.Generic.List(Of ATT00500Back.ATT00500HeaderGridDTO),
              ByVal poParShiftInformationStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00500ShiftInformationStreamDTO),
              ByVal poParHistoryStreaming As System.Collections.Generic.List(Of ATT00500Back.ATT00510StreamingDTO),
              ByVal poParHistoryRegular As ATT00500Back.ATT00510RegulerDTO)

End Interface
