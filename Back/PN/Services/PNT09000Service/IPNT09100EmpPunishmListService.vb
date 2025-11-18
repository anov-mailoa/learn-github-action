Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09100EmpPunishmListService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09100EmpPunishmListService

    Inherits R_IServicebase(Of PNT09100DTO)

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParams As List(Of PNT09100ReportDTO))

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function saveDocument(ByVal poParameter As PNT09100DTO) As PNT09100DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function removeDocument(ByVal poParameter As PNT09100DTO) As PNT09100DTO


End Interface
