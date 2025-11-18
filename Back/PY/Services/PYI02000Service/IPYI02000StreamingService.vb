Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYI02000Back

<ServiceContract()>
Public Interface IPYI02000StreamingService

    <OperationContract(Action:="GetInquiryTaxEmployeeList", ReplyAction:="GetInquiryTaxEmployeeList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetInquiryTaxEmployeeList() As Message

    <OperationContract(Action:="GetCmbPosition", ReplyAction:="GetCmbPosition")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbPosition() As Message

    <OperationContract(Action:="GetCmbLocation", ReplyAction:="GetCmbLocation")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbLocation() As Message

    <OperationContract(Action:="GetCmbDepartment", ReplyAction:="GetCmbDepartment")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbDepartment() As Message


End Interface
