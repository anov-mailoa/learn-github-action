Imports System.ServiceModel
Imports R_Common
Imports QAM00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00100StreamingService

    <OperationContract(Action:="GetCmbDepartmentLevel", ReplyAction:="GetCmbDepartmentLevel")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbDepartmentLevel() As Message

    <OperationContract(Action:="GetCmbLoadQA", ReplyAction:="GetCmbLoadQA")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbLoadQA() As Message


End Interface
