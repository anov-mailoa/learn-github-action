Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00830Back
Imports ATT00830Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00830StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00830StreamingService
     
    <OperationContract(Action:="getHolidayTransaction", ReplyAction:="getHolidayTransaction")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHolidayTransaction() As Message

    <OperationContract(Action:="getHolidayTransactionDetail", ReplyAction:="getHolidayTransactionDetail")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHolidayTransactionDetail() As Message

    <OperationContract(Action:="getHolidayLookup", ReplyAction:="getHolidayLookup")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHolidayLookup() As Message

End Interface
