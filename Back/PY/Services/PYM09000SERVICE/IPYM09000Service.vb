Imports System.ServiceModel
Imports R_Common
Imports PYM09000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM09000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM09000Service
    Inherits R_IServicebase(Of PYM09000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMinMaxDurasiDispensasi(poParam As PYM09000DTO) As Integer

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMinTahunDispensasi(poParam As PYM09000DTO) As String

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function cekProsesGaji(poParam As PYM09000DTO) As Boolean


    'KATEGORI
    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function saveKategoriDispensasiPajak(poParam As PYM09000DTO) As Boolean

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub deleteKategoriDispensasiPajak(poParam As PYM09000DTO)

    'KOMPONEN
    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkEnableGrupGaji(poParam As PYM09000DTO) As Boolean

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub deleteKomponenDispensasiPajak(poParam As PYM09000DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveKomponenDispensasiPajak(poParam As PYM09000DTO)

End Interface
