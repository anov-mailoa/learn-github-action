Imports System.ServiceModel
Imports R_Common
Imports QAI00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAI00100StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAI00100StreamService

    <OperationContract(Action:="getListGridDocument", ReplyAction:="getListGridDocument")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridDocument() As Message

    <OperationContract(Action:="getListRelatedDocument", ReplyAction:="getListRelatedDocument")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListRelatedDocument() As Message

End Interface
