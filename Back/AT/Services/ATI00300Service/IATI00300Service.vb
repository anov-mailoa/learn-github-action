Imports System.ServiceModel
Imports R_Common
Imports ATI00300Back
Imports R_BackEnd 
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATI00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IATI00300Service
    Inherits R_IServicebase(Of ATI00300DTO)
     
End Interface
