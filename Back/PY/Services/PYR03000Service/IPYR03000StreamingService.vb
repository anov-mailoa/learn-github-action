Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYR03000Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR03000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR03000StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getCompanyTaxId", ReplyAction:="getCompanyTaxId")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getCompanyTaxId() As Message

    <OperationContract(Action:="getSptPeriod", ReplyAction:="getSptPeriod")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getSptPeriod() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSptSetting(poParam As PYR03000DTO) As PYR03000DTO

End Interface
