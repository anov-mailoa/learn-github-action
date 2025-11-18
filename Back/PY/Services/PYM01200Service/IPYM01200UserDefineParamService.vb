Imports System.ServiceModel
Imports R_Common
Imports PYM01200Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01200UserDefineParamService" in both code and config file together.

<ServiceContract()>
Public Interface IPYM01200UserDefineParamService
    Inherits R_IServicebase(Of PYM01200UserDefineParamDTO)

End Interface
