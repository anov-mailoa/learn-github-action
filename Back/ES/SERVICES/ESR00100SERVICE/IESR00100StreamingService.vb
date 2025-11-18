Imports R_Common
Imports ESR00100Back
Imports ESR00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESR00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESR00100StreamingService

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParam As ParameterDTO)
End Interface
