Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNM04100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM04100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM04100StreamingService

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PNM04100PnmFacilitiesGridDto))

    <OperationContract(Action:="getListOfFacilities", ReplyAction:="getListOfFacilities")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListOfFacilities() As Message

    <OperationContract(Action:="getPnmOrgStructure", ReplyAction:="getPnmOrgStructure")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmOrgStructure() As Message

    <OperationContract(Action:="getListOfPositions", ReplyAction:="getListOfPositions")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListOfPositions() As Message

    <OperationContract(Action:="getPnmOrgStructureP", ReplyAction:="getPnmOrgStructureP")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmOrgStructureP() As Message

    <OperationContract(Action:="getPnmOrgStructurePDet", ReplyAction:="getPnmOrgStructurePDet")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmOrgStructurePDet() As Message

    <OperationContract(Action:="getListOfBatch", ReplyAction:="getListOfBatch")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getListOfBatch() As Message

    <OperationContract(Action:="getExcelData", ReplyAction:="getExcelData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExcelData() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message
End Interface
