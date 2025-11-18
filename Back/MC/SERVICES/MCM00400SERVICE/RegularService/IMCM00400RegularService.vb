Imports System.ServiceModel
Imports MCM00400Back
Imports R_BackEnd
Imports R_Common

<ServiceContract()>
Public Interface IMCM00400RegularService
    Inherits R_IServicebase(Of MCM00400GridDto)

End Interface
