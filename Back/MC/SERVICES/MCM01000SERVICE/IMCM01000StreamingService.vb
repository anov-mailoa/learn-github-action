Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCM01000StreamingService
    <OperationContract(Action:="GetYearList", ReplyAction:="GetYearList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYearList() As Message

    <OperationContract(Action:="GetCMBRateType", ReplyAction:="GetCMBRateType")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCMBRateType() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poGrid As MCM01000GridDTO)

    <OperationContract(Action:="GetDlogList", ReplyAction:="GetDlogList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogList() As Message
End Interface
