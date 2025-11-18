Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNM00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00200CategoryService" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00200CategoryService
    Inherits R_IServicebase(Of LNM00200Category_R)

End Interface
