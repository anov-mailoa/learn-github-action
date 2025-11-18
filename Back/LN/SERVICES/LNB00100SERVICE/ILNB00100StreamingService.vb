Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports LNB00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNB00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNB00100StreamingService

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of LNB00100Dto))

    <OperationContract(Action:="getDataDetail", ReplyAction:="getDataDetail")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getDataDetail() As Message


    <OperationContract()>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkFestivalInterfaceStatus(poParam As LNB00100Dto) As String


End Interface
