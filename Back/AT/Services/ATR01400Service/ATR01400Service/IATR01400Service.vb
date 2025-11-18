Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATR01400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01400Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR01400Service

    Inherits R_IServicebase(Of ATR01400DTO)

End Interface
