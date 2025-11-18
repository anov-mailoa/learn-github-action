Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM0500Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00500Service
    Inherits R_IServicebase(Of ATM00500DTO)


End Interface
