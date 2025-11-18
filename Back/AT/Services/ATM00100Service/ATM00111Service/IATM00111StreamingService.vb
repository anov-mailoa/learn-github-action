Imports System.ServiceModel
Imports ATM00100Back
Imports R_Common
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00111StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00111StreamingService

   

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message




End Interface
