Imports System.ServiceModel
Imports R_Common
Imports ESM00250Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00250Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00250Service

    Inherits R_IServicebase(Of ESM00250DTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Sub saveGeneralAccess(poNewEntity As Dictionary(Of String, String))

End Interface
