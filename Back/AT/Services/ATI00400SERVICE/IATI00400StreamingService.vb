Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATI00400Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATI00400StreamingService
     
    <OperationContract(Action:="getLogData", ReplyAction:="getLogData")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLogData() As Message
     
End Interface
