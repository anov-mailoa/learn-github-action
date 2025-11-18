Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCR10000BACK
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR10000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR10000StreamingService

    <OperationContract(Action:="GetYear", ReplyAction:="GetYear")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetYear(pcCompId As String) As String

    <OperationContract(Action:="GetReport", ReplyAction:="GetReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetReport() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poPar As List(Of MCR10000DTO))
End Interface
