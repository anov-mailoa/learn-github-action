Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT09000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT09000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT09000StreamingService

    <OperationContract(Action:="GetGvSubItem", ReplyAction:="GetGvSubItem")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetGvSubItem() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of MCT09000SubItemGvDto))

End Interface
