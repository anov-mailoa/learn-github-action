Imports R_Common
Imports ESM01400Back
Imports ESM01400Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01400Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM01400Service
    Inherits R_IServicebase(Of ESM01400ParameterDTO)


End Interface
