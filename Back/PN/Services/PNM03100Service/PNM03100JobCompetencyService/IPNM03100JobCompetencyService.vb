Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100JobCompetencyService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100JobCompetencyService
    Inherits R_IServicebase(Of PNM03100JobCompetencyDTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkDetail(poParam As PNM03100JobCompetencyDTO) As Boolean

End Interface
