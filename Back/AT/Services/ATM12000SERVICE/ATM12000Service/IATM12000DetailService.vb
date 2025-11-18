Imports System.ServiceModel
Imports R_Common
Imports ATM12000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM12000Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM12000DetailService
    Inherits R_IServicebase(Of ATM12000DetailDTO)

End Interface
