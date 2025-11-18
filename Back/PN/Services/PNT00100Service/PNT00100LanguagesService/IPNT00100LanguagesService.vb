Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100LanguagesService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100LanguagesService
    Inherits R_IServicebase(Of PNT00100LanguageGridDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function saveDocument(ByVal poParameter As PNT00100LanguageGridDTO) As PNT00100LanguageGridDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function removeDocument(ByVal poParameter As PNT00100LanguageGridDTO) As PNT00100LanguageGridDTO

End Interface
