Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCM00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM00200SubMedicalItemService" in both code and config file together.
<ServiceContract()>
Public Interface IMCM00200SubMedicalItemService

    Inherits R_IServicebase(Of MCM00200GridSubMedItemDTO)

End Interface
