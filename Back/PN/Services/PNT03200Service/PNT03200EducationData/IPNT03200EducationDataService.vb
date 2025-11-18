Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03200EducationDataService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03200EducationDataService
    Inherits R_IServicebase(Of PNT03200EducationDataDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function saveDocument(ByVal poParameter As PNT03200EducationDataDTO) As PNT03200EducationDataDTO

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function removeDocument(ByVal poParameter As PNT03200EducationDataDTO) As PNT03200EducationDataDTO


End Interface
