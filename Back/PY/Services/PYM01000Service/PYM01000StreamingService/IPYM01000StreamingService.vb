Imports System.ServiceModel
Imports R_Common
Imports PYM01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01000StreamingService

    <OperationContract(Action:="getPYM01000Grid", ReplyAction:="getPYM01000Grid")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPYM01000Grid() As Message


End Interface
