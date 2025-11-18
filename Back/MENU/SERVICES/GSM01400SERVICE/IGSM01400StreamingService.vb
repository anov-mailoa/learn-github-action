Imports System.ServiceModel
Imports R_Common
Imports GSM01400Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01400StreamingService

    <OperationContract(Action:="getMasterTemplateList", ReplyAction:="getMasterTemplateList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMasterTemplateList() As Message


End Interface
