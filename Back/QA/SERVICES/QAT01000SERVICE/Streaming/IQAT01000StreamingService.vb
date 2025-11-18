Imports System.ServiceModel
Imports R_Common
Imports QAT01000Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT01000StreamingService
    <OperationContract(Action:="getAttachmentList", ReplyAction:="getAttachmentList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getAttachmentList() As Message


End Interface
