Imports PNT90000Back
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT90000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT90000StreamingService

    <OperationContract(Action:="getTransaction", ReplyAction:="getTransaction")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

End Interface
