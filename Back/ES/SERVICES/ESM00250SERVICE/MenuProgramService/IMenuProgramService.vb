Imports System.ServiceModel
Imports R_Common
Imports ESM00250Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMenuProgramService" in both code and config file together.
<ServiceContract()>
Public Interface IMenuProgramService
    Inherits R_IServicebase(Of ESM00250MenuProgramDTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Sub saveButtonAccess(poParam As ESM00250MenuProgramDTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Sub saveGeneralAccess(poparam As ESM00250MenuProgramDTO)
End Interface
