Imports System.ServiceModel
Imports R_Common
Imports QAR01500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01500Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01500Service

    Inherits R_IServicebase(Of QAR01500DTO)


End Interface
