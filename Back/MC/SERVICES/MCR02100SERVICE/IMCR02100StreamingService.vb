Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCR02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR02100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR02100StreamingService

    <OperationContract(Action:="getExcel", ReplyAction:="getExcel")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExcel() As Message

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of MCR02100Dto))
End Interface
