Imports System.ServiceModel
Imports R_Common
Imports ESM00300Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00300Service
    Inherits R_IServicebase(Of ESM00300DTO)


    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkUseEssMember(poParam As ESM00300DTO) As Boolean

End Interface
