Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATR02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR02100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR02100Service

    Inherits R_IServicebase(Of ATR02100DTO)

End Interface
