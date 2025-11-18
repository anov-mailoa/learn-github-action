Imports System.ServiceModel
Imports R_Common
Imports PQM00200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPQM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPQM00200Service

    Inherits R_IServicebase(Of PQM00200Dto)

End Interface
