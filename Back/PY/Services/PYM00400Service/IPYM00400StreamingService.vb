Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00400StreamingService

    <OperationContract(Action:="getDataPPH21", ReplyAction:="getDataPPH21")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getDataPPH21() As Message

    <OperationContract(Action:="getDataKPPMaster", ReplyAction:="getDataKPPMaster")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getDataKPPMaster() As Message

    <OperationContract(Action:="getPKPDataList", ReplyAction:="getPKPDataList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getPKPDataList() As Message

    <OperationContract(Action:="getDataSevern", ReplyAction:="getDataSevern")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getDataSevern() As Message

    <OperationContract(Action:="getSevernPKPDataList", ReplyAction:="getSevernPKPDataList")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getSevernPKPDataList() As Message

    <OperationContract(Action:="getGridCustomTax", ReplyAction:="getGridCustomTax")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getGridCustomTax() As Message

    <OperationContract(Action:="getCmbPeriod", ReplyAction:="getCmbPeriod")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbPeriod() As Message

    <OperationContract(Action:="getPeriode", ReplyAction:="getPeriode")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriode() As Message

    <OperationContract(Action:="getPKPHD", ReplyAction:="getPKPHD")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPKPHD() As Message

    <OperationContract(Action:="getPKPDT", ReplyAction:="getPKPDT")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPKPDT() As Message

End Interface
