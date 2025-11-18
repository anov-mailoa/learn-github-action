Imports System.ServiceModel
Imports R_Common
Imports ATM00600Back
Imports R_BackEnd
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00600Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00600Service
    Inherits R_IServicebase(Of ATM00600DTO)
   

End Interface
