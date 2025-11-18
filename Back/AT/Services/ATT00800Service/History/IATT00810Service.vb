Imports ATT00800Back
Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00810Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00810Service

    Inherits R_IServicebase(Of ATT00810DTO)

End Interface
