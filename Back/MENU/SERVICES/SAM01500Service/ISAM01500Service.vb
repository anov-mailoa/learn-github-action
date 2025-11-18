Imports System.ServiceModel
Imports SAM01500Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01500Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM01500Service

    Inherits R_IServicebase(Of SAM01500DTO)

End Interface
