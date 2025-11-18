Imports System.ServiceModel
Imports R_Common
Imports GSM21000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM21000TranslateService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM21000TranslateService

    Inherits R_IServicebase(Of GSM21000TranslateDTO)

End Interface
