Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM00100Back

<ServiceContract()>
Public Interface IMCM00100StreamingService

    <OperationContract(Action:="getGridHdList", ReplyAction:="getGridHdList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridHdList() As Message

    <OperationContract(Action:="getGridPicList", ReplyAction:="getGridPicList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridPicList() As Message

    <OperationContract(Action:="getGridMpdList", ReplyAction:="getGridMpdList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridMpdList() As Message

    <OperationContract(Action:="getAttachment", ReplyAction:="getAttachment")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAttachment() As Message

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid1 As List(Of MCM00100GridHdDto))

End Interface
