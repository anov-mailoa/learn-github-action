Imports System.ServiceModel
Imports R_Common
Imports LNM00300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM0300Service_Streaming" in both code and config file together.
<ServiceContract()>
Public Interface ILNM0300Service_Streaming

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataGrid() As Message

End Interface
