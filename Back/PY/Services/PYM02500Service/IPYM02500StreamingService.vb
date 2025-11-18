Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYM02500Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM02500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM02500StreamingService


    <OperationContract(Action:="getListOfSubGrade", ReplyAction:="getListOfSubGrade")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListOfSubGrade() As Message

    <OperationContract(Action:="getListCurrency", ReplyAction:="getListCurrency")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListCurrency() As Message

End Interface
