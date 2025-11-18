Imports System.ServiceModel
Imports R_Common
Imports GSM01500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01500Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01500Service
    Inherits R_IServicebase(Of GSM01500DTO)

End Interface
