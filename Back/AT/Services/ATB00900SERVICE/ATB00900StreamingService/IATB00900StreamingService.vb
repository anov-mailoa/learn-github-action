Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATB00900Back
Imports ATB00900Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00900StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATB00900StreamingService


    <OperationContract(Action:="getData", ReplyAction:="getData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message


End Interface
