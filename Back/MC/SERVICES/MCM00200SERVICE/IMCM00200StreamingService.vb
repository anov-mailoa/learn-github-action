Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports MCM00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCM00200StreamingService

    <OperationContract(Action:="getMcmMedicalItem", ReplyAction:="getMcmMedicalItem")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmMedicalItem() As Message

    <OperationContract(Action:="getMcmMedicalItemPartner", ReplyAction:="getMcmMedicalItemPartner")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmMedicalItemPartner() As Message

    <OperationContract(Action:="getMcmMedicalSubitem", ReplyAction:="getMcmMedicalSubitem")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmMedicalSubitem() As Message

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of MCM00200GridDTO))

End Interface
