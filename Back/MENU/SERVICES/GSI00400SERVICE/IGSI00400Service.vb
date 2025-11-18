Imports System.ServiceModel
Imports GSI00400Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSI00400Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSI00400Service
    Inherits R_IServicebase(Of GSI00400DTO)

End Interface
