Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports GSB00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSB00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSB00100Service
    Inherits R_IServicebase(Of GSB00100DTO)
   
End Interface
