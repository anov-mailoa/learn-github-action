Imports System.ServiceModel
Imports R_BackEnd
Imports SAM02700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02700Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02700Service

    Inherits R_IServicebase(Of SAM02700DTO)

End Interface
