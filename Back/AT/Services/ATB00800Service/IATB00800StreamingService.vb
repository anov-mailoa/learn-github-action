Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATB00800Back
Imports ATB00800Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATB00800StreamingService
     
    <OperationContract(Action:="getPresentProcess", ReplyAction:="getPresentProcess")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPresentProcess() As Message

    <OperationContract(Action:="getSearchEmployee", ReplyAction:="getSearchEmployee")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSearchEmployee() As Message

    <OperationContract(Action:="getPresentProcessDetail", ReplyAction:="getPresentProcessDetail")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPresentProcessDetail() As Message

    <OperationContract(Action:="getLookUpWorkGroup", ReplyAction:="getLookUpWorkGroup")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpWorkGroup() As Message

    <OperationContract(Action:="getPresentProcessHistory", ReplyAction:="getPresentProcessHistory")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPresentProcessHistory() As Message

    <OperationContract(Action:="getPresentProcessInquiry", ReplyAction:="getPresentProcessInquiry")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPresentProcessInquiry() As Message
  


End Interface
