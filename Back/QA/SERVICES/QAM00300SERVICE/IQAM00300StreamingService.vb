Imports R_BackEnd
Imports R_Common
Imports QAM00300Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00300StreamingService

    <OperationContract(Action:="getListGrid", ReplyAction:="getListGrid")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGrid() As Message

End Interface
