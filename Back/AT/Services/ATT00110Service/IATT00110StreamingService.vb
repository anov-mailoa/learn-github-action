Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00110Back
Imports ATT00110Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00110StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00110StreamingService
     
    <OperationContract(Action:="getWorkingOrder", ReplyAction:="getWorkingOrder")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkingOrder() As Message

    <OperationContract(Action:="getRSP_AT_GET_EXCESS_FOR_OVERTIME", ReplyAction:="getRSP_AT_GET_EXCESS_FOR_OVERTIME")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRSP_AT_GET_EXCESS_FOR_OVERTIME() As Message

    <OperationContract(Action:="getWorkingOrderDT", ReplyAction:="getWorkingOrderDT")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkingOrderDT() As Message

End Interface
