Imports System.ServiceModel
Imports PYM01000Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01000Service
    Inherits R_IServicebase(Of PYM01000DTO)

End Interface
