Imports R_BackEnd
Imports R_Common
Imports PND00100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPND00100StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poDummy As List(Of PND00100ParamDTO))

    <OperationContract(Action:="getRSP_PN_DASHBOARD_INFO", ReplyAction:="getRSP_PN_DASHBOARD_INFO")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getRSP_PN_DASHBOARD_INFO() As Message

End Interface
