Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATR01500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01500Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR01500Service
    Inherits R_IServicebase(Of ATR01500DTO)

End Interface
