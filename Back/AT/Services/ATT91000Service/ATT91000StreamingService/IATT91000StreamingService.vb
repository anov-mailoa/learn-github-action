Imports System.ServiceModel
Imports R_Common
Imports ATT91000Back
Imports ATT91000Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT91000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT91000StreamingService

    <OperationContract(Action:="getListMassLeave", ReplyAction:="getListMassLeave")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListMassLeave() As Message

    <OperationContract(Action:="getListMassLeaveHistory", ReplyAction:="getListMassLeaveHistory")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListMassLeaveHistory() As Message

    <OperationContract(Action:="getHeaderDetail", ReplyAction:="getHeaderDetail")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeaderDetail() As Message

End Interface
