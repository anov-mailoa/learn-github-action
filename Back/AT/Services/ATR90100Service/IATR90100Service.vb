Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR90100Service
    Inherits R_IServicebase(Of ATR90100DTO)

End Interface
