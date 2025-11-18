Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ATM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00400StreamingService
    <OperationContract(Action:="EmployeeCard", ReplyAction:="EmployeeCard")> _
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAtmCard() As Message

    <OperationContract(Action:="getDataXls", ReplyAction:="getDataXls")> _
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataXls() As Message

    <OperationContract(Action:="Employee", ReplyAction:="Employee")> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPnmEmpOffice() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract(Action:="getAttendanceId", ReplyAction:="getAttendanceId")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAttendanceId() As Message

    <OperationContract(Action:="CekAtmCard", ReplyAction:="CekAtmCard")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function cekAtmCard() As Message

    <OperationContract(Action:="getDeptDB", ReplyAction:="getDeptDB")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDeptDB() As Message

    <OperationContract(Action:="getWorkGroupDB", ReplyAction:="getWorkGroupDB")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkGroupDB() As Message

    <OperationContract(Action:="getAnnualLeaveDB", ReplyAction:="getAnnualLeaveDB")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAnnualLeaveDB() As Message

    <OperationContract(Action:="getAnnual", ReplyAction:="getAnnual")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAnnual() As Message
     
    <OperationContract(Action:="getWorkGroup", ReplyAction:="getWorkGroup")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkGroup() As Message

    <OperationContract(Action:="getCmbLeave", ReplyAction:="getCmbLeave")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbLeave() As Message

    <OperationContract(Action:="getCmbGroup", ReplyAction:="getCmbGroup")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbGroup() As Message

    <OperationContract(Action:="searchAttendanceId", ReplyAction:="searchAttendanceId")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function searchAttendanceId() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="RSP_AT_VALIDATE_EMPLOYEE_MASTER", ReplyAction:="RSP_AT_VALIDATE_EMPLOYEE_MASTER")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_AT_VALIDATE_EMPLOYEE_MASTER() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy()

End Interface
