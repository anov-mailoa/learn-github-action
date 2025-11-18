Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYM02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM02000Service
    Inherits R_IServicebase(Of PYM02000DTO)

End Interface
