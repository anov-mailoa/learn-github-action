Imports System.ServiceModel
Imports R_Common
Imports SAM02100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02100StreamingService

    <OperationContract(Action:="getTemplateList", ReplyAction:="getTemplateList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTemplateList() As Message

    <OperationContract(Action:="getViewTemplate", ReplyAction:="getViewTemplate")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getViewTemplate() As Message
End Interface
