Imports System.ServiceModel
Imports ATI00200Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATI00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IATI00200Service

    Inherits R_IServicebase(Of ATI00200DTO)

End Interface
