Imports R_Common
Imports ESM01200Back
Imports ESM01200Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "Iesm01200PRService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01200PRService
    Inherits R_IServicebase(Of ESM01200PRParamDTO)

End Interface
