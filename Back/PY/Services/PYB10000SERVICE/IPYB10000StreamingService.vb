Imports System.ServiceModel
Imports R_Common
Imports PYB10000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB10000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB10000StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGrupGaji() As Message

    <OperationContract(Action:="getEmployees", ReplyAction:="getEmployees")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployees() As Message

    <OperationContract(Action:="getProcessCode", ReplyAction:="getProcessCode")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProcessCode() As Message

    <OperationContract(Action:="getCmbPeriod", ReplyAction:="getCmbPeriod")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPeriod() As Message


    <OperationContract(Action:="getCmbYear", ReplyAction:="getCmbYear")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbYear() As Message


    <OperationContract(Action:="getEmailProcessList", ReplyAction:="getEmailProcessList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmailProcessList() As Message

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub sendEmail(pcEmailId As String)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub insertEmailProcess(poParam As PYB10000DTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub savePublishESS(poParam As List(Of PYB10000PublishDTO))

End Interface
