Imports System.ServiceModel
Imports PYM01700Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01700Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01700Service
    Inherits R_IServicebase(Of PYM01700DTO)


End Interface
