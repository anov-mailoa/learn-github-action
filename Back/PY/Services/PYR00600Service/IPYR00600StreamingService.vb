Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR00600StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PYR00600DTO),
              ByVal poParam2 As List(Of PYR00600PivotDTO))

End Interface
