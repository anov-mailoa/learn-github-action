Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02400StreamingService

    <OperationContract(Action:="GetTypeList", ReplyAction:="GetTypeList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetTypeList() As Message

End Interface
