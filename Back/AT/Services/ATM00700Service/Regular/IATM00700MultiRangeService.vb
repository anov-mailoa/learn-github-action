Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00700Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00700MultiRangeService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00700MultiRangeService
    Inherits R_IServicebase(Of ATM00700MultiRangeDTO)

End Interface
