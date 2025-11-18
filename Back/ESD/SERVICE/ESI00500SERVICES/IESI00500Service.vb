Imports R_Common
Imports ESI00500Back
Imports ESI00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESI00500Service" in both code and config file together.
<ServiceContract()>
Public Interface IESI00500Service

    Inherits R_IServicebase(Of ParameterDTO)


End Interface
