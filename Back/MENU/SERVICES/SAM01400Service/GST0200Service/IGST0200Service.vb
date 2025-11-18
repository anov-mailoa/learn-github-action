Imports System.ServiceModel
Imports SAM01400Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGST0200Service" in both code and config file together.
<ServiceContract()>
Public Interface IGST0200Service

    Inherits R_BackEnd.R_IServicebase(Of GST0200DTO)

End Interface
