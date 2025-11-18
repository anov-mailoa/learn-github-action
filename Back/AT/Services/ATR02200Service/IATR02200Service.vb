Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATR02200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR02200Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR02200Service

    Inherits R_IServicebase(Of ATR02200DTO)

End Interface
