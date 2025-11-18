Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCT02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT02000LimitCorDetService
    Inherits R_IServicebase(Of MCT02000LimitCorDetDTO)

End Interface
