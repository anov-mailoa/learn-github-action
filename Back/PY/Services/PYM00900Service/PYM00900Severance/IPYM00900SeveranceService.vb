Imports System.ServiceModel
Imports R_Common
Imports PYM00900Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00900SeveranceService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00900SeveranceService

    Inherits R_IServicebase(Of PYM00900SalaryProcessDTO)

End Interface
