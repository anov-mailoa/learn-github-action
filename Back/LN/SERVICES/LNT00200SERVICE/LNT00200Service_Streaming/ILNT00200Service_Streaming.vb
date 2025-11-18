Imports System.ServiceModel
Imports R_Common
Imports LNT00200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00200Service_Streaming" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00200Service_Streaming

    <OperationContract(Action:="getList", ReplyAction:="getList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDisbursement() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParDisbursement As System.Collections.Generic.List(Of LNT00200Dto_R))

End Interface
