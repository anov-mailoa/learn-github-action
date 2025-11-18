Imports System.ServiceModel
Imports R_Common
Imports SAM01300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01300Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM01300Service

    Inherits R_IServicebase(Of SAM01300DTO)

End Interface
