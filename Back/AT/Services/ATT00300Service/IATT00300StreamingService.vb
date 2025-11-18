Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00300Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00300StreamingService
    <OperationContract(Action:="getPermission", ReplyAction:="getPermission")>
                 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPermission() As Message

    <OperationContract(Action:="getReason", ReplyAction:="getReason")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReason() As Message


    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract(Action:="getLookUpEmployee", ReplyAction:="getLookUpEmployee")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployee() As Message

    <OperationContract(Action:="getCmbShift", ReplyAction:="getCmbShift")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbShift() As Message
     

End Interface
