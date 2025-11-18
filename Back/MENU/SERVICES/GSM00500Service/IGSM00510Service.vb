Imports System.ServiceModel
Imports R_Common
Imports GSM00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00510Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00510Service
    Inherits R_IServicebase(Of GSM00510DTO)

End Interface
