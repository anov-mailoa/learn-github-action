Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNM14300Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14300StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PNM14300GridDTO))


    <OperationContract(Action:="getListGrid", ReplyAction:="getListGrid")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getListGrid() As Message

End Interface
