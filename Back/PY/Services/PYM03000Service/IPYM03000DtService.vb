Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYM03000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM03000DtService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM03000DtService
    Inherits R_IServicebase(Of PYM03000DtDTO)

End Interface
