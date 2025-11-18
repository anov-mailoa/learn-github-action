Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM09000StreamingService

    <OperationContract(Action:="getDispensasiList", ReplyAction:="getDispensasiList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDispensasiList() As Message

    <OperationContract(Action:="getPeriodeDispensasi", ReplyAction:="getPeriodeDispensasi")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPeriodeDispensasi() As Message

    'KATEGORI
    <OperationContract(Action:="getKategoriDispensasiPajakList", ReplyAction:="getKategoriDispensasiPajakList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getKategoriDispensasiPajakList() As Message

    <OperationContract(Action:="getLookupKategoriDispensasi", ReplyAction:="getLookupKategoriDispensasi")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookupKategoriDispensasi() As Message

    'KOMPONEN
    <OperationContract(Action:="getGrupGajiList", ReplyAction:="getGrupGajiList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGrupGajiList() As Message

    <OperationContract(Action:="getKomponenList", ReplyAction:="getKomponenList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getKomponenList() As Message

    <OperationContract(Action:="getCmbBoxGrupGaji", ReplyAction:="getCmbBoxGrupGaji")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbBoxGrupGaji() As Message

    <OperationContract(Action:="getLookupKomponen", ReplyAction:="getLookupKomponen")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookupKomponen() As Message


End Interface
