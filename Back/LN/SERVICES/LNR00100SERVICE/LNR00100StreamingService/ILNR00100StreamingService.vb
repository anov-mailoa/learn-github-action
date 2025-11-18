Imports System.ServiceModel
Imports R_Common
Imports LNR00100Back
Imports System.ServiceModel.Channels
Imports LNR00100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00100StreamingService

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelData() As Message

    <OperationContract(Action:="getData", ReplyAction:="getData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getLoanTypeList", ReplyAction:="getLoanTypeList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getLoanTypeList() As Message

    <OperationContract(Action:="getPeriodList", ReplyAction:="getPeriodList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriodList() As Message

    'test
    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(poParReguler As System.Collections.Generic.List(Of LNR00100Dto_R),
              poParReport As System.Collections.Generic.List(Of ReportHeaderDTO))

End Interface
