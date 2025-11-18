Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATR03100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR03100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR03100Service

    Inherits R_IServicebase(Of ATR03100DTO)

End Interface
