Imports System.ServiceModel
Imports R_Common
Imports LNT00300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00300Service_Streaming" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00300Service_Streaming

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract(Action:="RSP_Installment_Schedule", ReplyAction:="RSP_Installment_Schedule")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Installment_Schedule() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00300Dto_R), _
              poListSchedule As System.Collections.Generic.List(Of LNT00300DtoSchedule_R))

End Interface
