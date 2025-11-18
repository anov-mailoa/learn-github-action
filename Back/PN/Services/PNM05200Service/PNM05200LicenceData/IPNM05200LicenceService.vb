Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05200LicenceService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05200LicenceService
    Inherits R_IServicebase(Of PNM05200LicenceDTO)


    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function saveDocument(ByVal poParameter As PNM05200LicenceDTO) As PNM05200LicenceDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function removeDocument(ByVal poParameter As PNM05200LicenceDTO) As PNM05200LicenceDTO

End Interface
