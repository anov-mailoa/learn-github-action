Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNM14400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14400StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PNM14400PesertaBpjsKesehatanGridDTO),
              ByVal poParam2 As List(Of PNM14400AnggotaBpjsGridDTO))

    <OperationContract(Action:="getListGrid", ReplyAction:="getListGrid")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getListGrid() As Message

    <OperationContract(Action:="getKelasRawatInapList", ReplyAction:="getKelasRawatInapList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getKelasRawatInapList() As Message

    <OperationContract(Action:="getListDataKKGrid", ReplyAction:="getListDataKKGrid")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getListDataKKGrid() As Message

End Interface
