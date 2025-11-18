Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00500StreamingService

    <OperationContract(Action:="getBpjstk", ReplyAction:="getBpjstk")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBpjstk() As Message

    <OperationContract(Action:="getBpjstkParameter", ReplyAction:="getBpjstkParameter")>
                <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBpjstkParameter() As Message

    <OperationContract(Action:="getJamsostekParameter", ReplyAction:="getJamsostekParameter")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getJamsostekParameter() As Message

    <OperationContract(Action:="getCity", ReplyAction:="getCity")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCity() As Message

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParPYM00500 As System.Collections.Generic.List(Of PYM00500ParameterHeaderDTO),
              poParPYM00502 As System.Collections.Generic.List(Of PYM00500PerusahaanHeaderDTO))

End Interface
