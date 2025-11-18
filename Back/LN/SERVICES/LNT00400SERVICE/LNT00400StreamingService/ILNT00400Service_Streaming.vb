Imports System.ServiceModel
Imports R_Common
Imports LNT00400Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00400Service_Streaming" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00400Service_Streaming

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract(Action:="getCombo", ReplyAction:="getCombo")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCombo() As Message

    <OperationContract(Action:="getCorrectableInstallment", ReplyAction:="getCorrectableInstallment")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCorrectableInstallment() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParStreaming As System.Collections.Generic.List(Of LNT00400Dto_R), _
              ByVal poInstallmentS As System.Collections.Generic.List(Of LNT00400_InstallmentDto))
End Interface
