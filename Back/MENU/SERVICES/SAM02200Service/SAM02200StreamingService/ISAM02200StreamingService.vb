Imports System.ServiceModel
Imports R_Common
Imports SAM02200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02200StreamingService

    <OperationContract(Action:="getTemplateList", ReplyAction:="getTemplateList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTemplateList() As Message

    <OperationContract(Action:="getProgramList", ReplyAction:="getProgramList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProgramList() As Message

    <OperationContract(Action:="getRecordDocument", ReplyAction:="getRecordDocument")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecordDocument() As Message
End Interface
