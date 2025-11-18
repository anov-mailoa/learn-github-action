Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05200WorkExperienceService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05200WorkExperienceService
    Inherits R_IServicebase(Of PNM05200WorkExperienceDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCountry(poParam As PNM05200WorkExperienceDTO) As List(Of PNM05200WorkExperienceDTO)
End Interface
