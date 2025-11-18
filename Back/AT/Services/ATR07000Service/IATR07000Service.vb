Imports System.ServiceModel
Imports ATR07000Back
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR07000Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR07000Service
    Inherits R_IServicebase(Of ATR07000DTO)

End Interface
