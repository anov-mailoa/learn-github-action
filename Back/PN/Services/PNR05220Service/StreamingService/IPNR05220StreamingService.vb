Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR05220Back

<ServiceContract()>
Public Interface IPNR05220StreamingService

    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeList() As Message

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

End Interface
