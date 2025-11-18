Imports System.ServiceModel
Imports R_Common
Imports PQM00400Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPQM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPQM00400Service

    Inherits R_IServicebase(Of PQM00400Dto)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function ValidateService(poParam As PQM00400Dto) As PQM00400Dto
End Interface
