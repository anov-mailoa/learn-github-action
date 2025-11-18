Imports System.ServiceModel
Imports R_BackEnd
Imports SAM02600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02600Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02600Service

    Inherits R_IServicebase(Of SAM02600DTO)

End Interface
