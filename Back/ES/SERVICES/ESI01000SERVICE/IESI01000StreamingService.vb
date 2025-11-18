Imports R_Common
Imports ESI01000Back
Imports ESI01000Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESI01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESI01000StreamingService

    <OperationContract(Action:="getSearchList", ReplyAction:="getSearchList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSearchList() As Message

    <OperationContract(Action:="getCmbTransType", ReplyAction:="getCmbTransType")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTransType() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParam As ParameterDTO)
End Interface
