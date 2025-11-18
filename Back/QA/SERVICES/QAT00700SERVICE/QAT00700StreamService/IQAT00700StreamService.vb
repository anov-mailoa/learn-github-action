Imports System.ServiceModel
Imports R_Common
Imports QAT00700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00700StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00700StreamService
    <OperationContract(Action:="GetDEPARTMENT_USER", ReplyAction:="GetDEPARTMENT_USER")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDEPARTMENT_USER() As Message

    <OperationContract(Action:="GetDOCUMENTS", ReplyAction:="GetDOCUMENTS")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDOCUMENTS() As Message

    <OperationContract(Action:="GetATTACHMENTS", ReplyAction:="GetATTACHMENTS")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetATTACHMENTS() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar2 As List(Of QAT00700Grid2Dto))
End Interface
