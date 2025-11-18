Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PYM03000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM03000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM03000StreamingService

    <OperationContract(Action:="getCmbDimension", ReplyAction:="getCmbDimension")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbDimension() As Message

    <OperationContract(Action:="getListUsedSalaryRange", ReplyAction:="getListUsedSalaryRange")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListUsedSalaryRange() As Message

End Interface
