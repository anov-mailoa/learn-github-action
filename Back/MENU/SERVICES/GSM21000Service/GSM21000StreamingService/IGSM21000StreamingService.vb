Imports System.ServiceModel
Imports R_Common
Imports GSM21000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM21000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM21000StreamingService

    <OperationContract(Action:="GetClassificationHeader", ReplyAction:="GetClassificationHeader")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetClassificationHeader() As Message

    <OperationContract(Action:="GetClassificationDetail", ReplyAction:="GetClassificationDetail")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetClassificationDetail() As Message

    <OperationContract(Action:="GetClassificationHDChild", ReplyAction:="GetClassificationHDChild")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetClassificationHDChild() As Message

    <OperationContract(Action:="GetTranslate", ReplyAction:="GetTranslate")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTranslate() As Message

    <OperationContract(Action:="GetCompanyAssignment", ReplyAction:="GetCompanyAssignment")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCompanyAssignment() As Message

    <OperationContract(Action:="GetCmbCompany", ReplyAction:="GetCmbCompany")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbCompany() As Message

End Interface
