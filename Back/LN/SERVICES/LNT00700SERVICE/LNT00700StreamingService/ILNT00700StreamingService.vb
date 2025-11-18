Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports LNT00700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00700StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00700Dto_R), _
              poSchedule As LNT00700ScheduleDto, poScheduleList As System.Collections.Generic.List(Of LNT00700ScheduleDto_S), poCmb As System.Collections.Generic.List(Of LNT00700PaymentTypeDto))
End Interface
