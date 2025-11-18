Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ATM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00400WorkGroupService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00400WorkGroupService
    Inherits R_IServicebase(Of ATM00400WorkGroupDTO)

End Interface
