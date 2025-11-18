Imports System.ServiceModel
Imports ATM00400Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00400AnnualService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00400AnnualService
    Inherits R_IServicebase(Of ATM00400AnnualDTO)

End Interface
