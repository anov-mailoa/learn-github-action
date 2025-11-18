Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATR91000Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR91000StreamingService

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(popar2 As List(Of ATR91000ParamDTO))

    <OperationContract(Action:="GetReport", ReplyAction:="GetReport")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReport() As Message

    <OperationContract(Action:="GetLookUp", ReplyAction:="GetLookUp")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLookUp() As Message

End Interface
