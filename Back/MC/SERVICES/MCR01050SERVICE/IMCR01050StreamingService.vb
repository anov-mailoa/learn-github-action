Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports MCR01050BACK
Imports MCR01050COMMON
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR01050StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR01050StreamingService

    <OperationContract(Action:="getExcel", ReplyAction:="getExcel")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExcel() As Message

    <OperationContract(Action:="GetReport", ReplyAction:="GetReport")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReport() As Message

    <OperationContract(Action:="GetYear", ReplyAction:="GetYear")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYear() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ParamDTO(ByVal poPar As List(Of MCR01050DTO))
End Interface
