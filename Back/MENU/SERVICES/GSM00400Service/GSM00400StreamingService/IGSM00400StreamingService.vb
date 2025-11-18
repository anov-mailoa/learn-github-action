Imports System.ServiceModel
Imports R_Common
Imports GSM00400Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00400StreamingService

    <OperationContract(Action:="getGridCenter", ReplyAction:="getGridCenter")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridCenter() As Message

    <OperationContract(Action:="getGridDept", ReplyAction:="getGridDept")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridDept() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of GSM00400DeptGridDTO))

End Interface
