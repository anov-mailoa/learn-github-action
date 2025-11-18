Imports System.ServiceModel
Imports R_Common
Imports PYM08010Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM08000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM08010Service
    Inherits R_IServicebase(Of PYM08010DTO)

End Interface
