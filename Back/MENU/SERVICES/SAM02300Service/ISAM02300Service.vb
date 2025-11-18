Imports System.ServiceModel
Imports SAM02300Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02300Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02300Service

    Inherits R_IServicebase(Of SAM02300DTO)

End Interface
