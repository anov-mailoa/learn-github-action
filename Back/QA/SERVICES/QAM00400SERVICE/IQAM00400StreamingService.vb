Imports R_BackEnd
Imports R_Common
Imports QAM00400Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00400StreamingService

    <OperationContract(Action:="getLoadGrid", ReplyAction:="getLoadGrid")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLoadGrid() As Message
End Interface
