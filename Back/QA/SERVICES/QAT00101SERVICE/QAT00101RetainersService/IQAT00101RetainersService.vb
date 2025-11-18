Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAT00101Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00101RetainersService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00101RetainersService
    Inherits R_IServicebase(Of QAT00101RetainersGridDTO)
     
End Interface
