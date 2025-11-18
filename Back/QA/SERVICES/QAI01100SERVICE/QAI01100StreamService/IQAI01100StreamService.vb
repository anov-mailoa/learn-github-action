Imports System.ServiceModel
Imports R_Common
Imports QAI01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAI01100StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAI01100StreamService
    <OperationContract(Action:="GetSOCDOCLIST", ReplyAction:="GetSOCDOCLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSOCDOCLIST() As Message

    <OperationContract(Action:="GetSOCATTLIST", ReplyAction:="GetSOCATTLIST")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSOCATTLIST() As Message

End Interface
