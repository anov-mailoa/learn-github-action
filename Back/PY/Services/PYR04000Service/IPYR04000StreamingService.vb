Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR04000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR04000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR04000StreamingService

    <OperationContract(Action:="getPeriod", ReplyAction:="getPeriod")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriod() As Message

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PYR04000DTO),
              ByVal poParam2 As List(Of PYR04001DTO),
              ByVal poParam3 As List(Of PYR04002DTO),
              ByVal poParam4 As List(Of PYR04003DTO),
              ByVal poParam5 As List(Of PYR04004DTO),
              ByVal poParam6 As List(Of PYR04005DTO),
              ByVal poParam7 As List(Of PYR04006DTO),
              ByVal poParam8 As List(Of PYR04007DTO),
              ByVal poParam9 As List(Of PYR04008DTO),
              ByVal poParam10 As List(Of PYR04000DetilPerusahaanDTO))

End Interface
