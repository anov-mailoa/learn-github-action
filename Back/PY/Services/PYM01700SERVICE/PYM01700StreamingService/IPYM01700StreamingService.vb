Imports System.ServiceModel
Imports R_Common
Imports PYM01700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01700StreamingService

    <OperationContract(Action:="getTaxStatusMapping", ReplyAction:="getTaxStatusMapping")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTaxStatusMapping() As Message

    <OperationContract(Action:="getChildFamilyMapping", ReplyAction:="getChildFamilyMapping")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getChildFamilyMapping() As Message

End Interface
