Imports R_BackEnd
Imports R_Common
Imports ATM00300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00300StreamingService

    <OperationContract(Action:="HolidayData", ReplyAction:="HolidayData")>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAtmHolidayParam() As Message

    <OperationContract(Action:="EmployeeData", ReplyAction:="EmployeeData")>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message


End Interface
