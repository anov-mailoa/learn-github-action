Imports System.ServiceModel
Imports R_Common
Imports QAT00201Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00201StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00201StreamingService
    <OperationContract(Action:="getDocOwnerList", ReplyAction:="getDocOwnerList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getDocOwnerList() As Message


    <OperationContract(Action:="getRevDocList", ReplyAction:="getRevDocList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getRevDocList() As Message


End Interface
