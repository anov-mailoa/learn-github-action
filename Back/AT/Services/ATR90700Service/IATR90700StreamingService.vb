Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATR90700Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR90700StreamingService


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(popar2 As List(Of ATR90700ParamDTO))

    <OperationContract(Action:="GetReport", ReplyAction:="GetReport")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReport() As Message

End Interface
