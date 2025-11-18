Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PNM14400Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14400Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14400Service

    Inherits R_IServicebase(Of PNM14400PesertaBpjsKesehatanDetailDTO)

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400PesertaBpjsKesehatanDetailDTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function Deactivate(poParam As PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400PesertaBpjsKesehatanDetailDTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeDetail(poParam As PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400PesertaBpjsKesehatanDetailDTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkEmployeeExist(pcCompId As String, pcEmpId As String)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getKodeBpjsPerusahaan(poParam As PNM14400PesertaBpjsKesehatanDetailDTO) As PNM14400PesertaBpjsKesehatanDetailDTO


End Interface
