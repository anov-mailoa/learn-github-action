Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90800Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90800Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR90800Service
    Inherits R_IServicebase(Of ATR90800DTO)

End Interface
