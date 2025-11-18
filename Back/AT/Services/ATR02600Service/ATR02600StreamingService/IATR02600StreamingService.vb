Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATR02600Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR02600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR02600StreamingService

    <OperationContract(Action:="SPData", ReplyAction:="SPData")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSP() As Message

    <OperationContract(Action:="AllEmployeeData", ReplyAction:="AllEmployeeData")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAllEmployee() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid As List(Of ATR02600GridDTO),
              poParSP As List(Of ATR02600SPDTO))
End Interface
