Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ATF00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATF00100StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IATF00100StreamService
    <OperationContract(Action:="getDetail", ReplyAction:="getDetail")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetail() As Message
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy3(ByVal poPar As List(Of ATF00100StreamDTO))
End Interface
