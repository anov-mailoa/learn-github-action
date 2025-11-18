Imports System.ServiceModel.Channels
Imports ATI00100Back
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATI00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATI00100StreamingService



    <OperationContract(Action:="getData", ReplyAction:="getData")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message

    <OperationContract(Action:="getCmb", ReplyAction:="getCmb")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmb() As Message

 
End Interface
