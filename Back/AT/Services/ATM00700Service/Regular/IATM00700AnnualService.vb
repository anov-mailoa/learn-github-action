Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00700Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00700AnnualService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00700AnnualService
    Inherits R_IServicebase(Of ATM00700AnnualLeaveDTO)



End Interface
