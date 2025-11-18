Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR08000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR08000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR08000StreamingService

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTemplateDetail(poParam As PYR08000DTO) As PYR08000DTO

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getExportExcelData() As Message

    <OperationContract(Action:="getInterfaceData", ReplyAction:="getInterfaceData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getInterfaceData() As Message

    <OperationContract(Action:="getList", ReplyAction:="getList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getList() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of PYR08000DTO))

End Interface
