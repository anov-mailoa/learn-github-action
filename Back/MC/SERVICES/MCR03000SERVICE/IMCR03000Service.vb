Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCR03000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR03000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCR03000Service

    Inherits R_IServicebase(Of MCR03000Dto)

End Interface
