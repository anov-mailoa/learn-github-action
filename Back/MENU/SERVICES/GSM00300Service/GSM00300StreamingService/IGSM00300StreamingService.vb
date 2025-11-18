Imports System.ServiceModel
Imports R_Common
Imports GSM00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00300StreamingService

    <OperationContract(Action:="getGridYear", ReplyAction:="getGridYear")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridYear() As Message


    <OperationContract(Action:="generatePeriod", ReplyAction:="generatePeriod")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function generatePeriod() As Message

    <OperationContract(Action:="getGridYearDetails", ReplyAction:="getGridYearDetails")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridYearDetails() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poPar1 As List(Of GSM00300YearGridDTO),
              poPar2 As List(Of GSM00300YearDetailGridDTO))

End Interface
