Imports System.ServiceModel
Imports R_Common
Imports PQM00500Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPQM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPQM00500Service

    Inherits R_IServicebase(Of PQM00500Dto)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function ValidateService(poParam As PQM00500Dto) As PQM00500Dto
End Interface
