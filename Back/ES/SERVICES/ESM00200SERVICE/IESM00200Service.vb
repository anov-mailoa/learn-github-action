Imports System.ServiceModel
Imports R_Common
Imports ESM00200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00200Service
    Inherits R_IServicebase(Of ESM00200DTO)


    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkUseInEssRole(poParam As ESM00200DTO) As Boolean

End Interface
