Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03200LicenceDataService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03200LicenceDataService
    Inherits R_IServicebase(Of PNT03200LicenceDataDTO)


    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function saveDocument(ByVal poParameter As PNT03200LicenceDataDTO) As PNT03200LicenceDataDTO

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function removeDocument(ByVal poParameter As PNT03200LicenceDataDTO) As PNT03200LicenceDataDTO



End Interface
