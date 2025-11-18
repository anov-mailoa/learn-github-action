Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports MCT01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT01000StreamingService

    <OperationContract(Action:="getMctPaymentHd", ReplyAction:="getMctPaymentHd")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMctPaymentHd() As Message

    <OperationContract(Action:="getMctPaymentDt", ReplyAction:="getMctPaymentDt")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMctPaymentDt() As Message

    <OperationContract(Action:="getMctPaymentSum", ReplyAction:="getMctPaymentSum")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMctPaymentSum() As Message

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of MCT01000GridDTO), poPar As System.Collections.Generic.List(Of MCT01000GridDtDTO), poPara As System.Collections.Generic.List(Of MCT01000GridSumDTO))

End Interface
