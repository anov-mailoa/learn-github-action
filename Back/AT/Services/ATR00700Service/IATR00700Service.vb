Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATR00700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00700Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00700Service

    Inherits R_IServicebase(Of ATR00700DTO)

End Interface
