Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00700DispensationService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00700DispensationService
    Inherits R_IServicebase(Of ATM00700DispensationDTO)

End Interface
