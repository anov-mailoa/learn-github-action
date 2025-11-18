Imports System.ServiceModel
Imports R_Common
Imports PYM00900Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00900StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00900StreamingService

    'HEADER
    <OperationContract(Action:="getGridPymSalaryGroupHd", ReplyAction:="getGridPymSalaryGroupHd")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridPymSalaryGroupHd() As Message

    'SALARY PROCESS TAB (NORMAL)
    <OperationContract(Action:="getComponentSalary", ReplyAction:="getComponentSalary")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComponentSalary() As Message

    'SALARY PROCESS TAB(AFTER TAX)
    <OperationContract(Action:="getComponentSalaryAfterTax", ReplyAction:="getComponentSalaryAfterTax")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComponentSalaryAfterTax() As Message

    'NON SALARY PROCESS (PROCESS CODE)
    <OperationContract(Action:="getSalaryGroupDt", ReplyAction:="getSalaryGroupDt")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroupDt() As Message

    'NON SALARY PROCESS (COMPONENT PROCESS)
    <OperationContract(Action:="getComponentProcess", ReplyAction:="getComponentProcess")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComponentProcess() As Message

    'NON SALARY PROCESS (AFTER TAX COMPONENT)
    <OperationContract(Action:="getComponentProcessAfterTax", ReplyAction:="getComponentProcessAfterTax")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComponentProcessAfterTax() As Message

    'PERIOD MANAGEMENT (YEAR)
    <OperationContract(Action:="getYearPeriod", ReplyAction:="getYearPeriod")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getYearPeriod() As Message

    'PERIOD MANAGEMENT (PROCESS PERIOD)
    <OperationContract(Action:="getProcessPeriod", ReplyAction:="getProcessPeriod")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProcessPeriod() As Message

    'PERIOD MANAGEMENT (INTERFACE PERIOD)
    <OperationContract(Action:="getInterfacePeriod", ReplyAction:="getInterfacePeriod")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getInterfacePeriod() As Message

    'PREDEFINED SEVERANCE
    <OperationContract(Action:="getSeveranceGrid", ReplyAction:="getSeveranceGrid")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSeveranceGrid() As Message

    'PREDEFINED MEMBER
    <OperationContract(Action:="getListMember", ReplyAction:="getListMember")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListMember() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar2 As List(Of PYM00900SalaryProcessGridDTO),
              ByVal poPar4 As List(Of PYM00900NonSalaryProcessGridDTO),
              ByVal poPar6 As List(Of PYM00900YearGridDTO),
              ByVal poPar8 As List(Of PYM00900ProcessPeriodGridDTO),
              ByVal poPar10 As List(Of PYM00900InterfacePeriodGridDTO),
              ByVal poPar12 As List(Of PYM00900MemberGridDTO))

End Interface
