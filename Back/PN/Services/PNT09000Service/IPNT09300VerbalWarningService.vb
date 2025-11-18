Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09300VerbalWarningService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09300VerbalWarningService

    Inherits R_IServicebase(Of PNT09300DTO)

End Interface
