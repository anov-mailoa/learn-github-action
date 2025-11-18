Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100FormalEducationService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100FormalEducationService
    Inherits R_IServicebase(Of PNT00100EducationDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function saveDocument(ByVal poParameter As PNT00100EducationDTO) As PNT00100EducationDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function removeDocument(ByVal poParameter As PNT00100EducationDTO) As PNT00100EducationDTO

End Interface
