Imports System.ServiceModel
Imports R_Common
Imports ESM01100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01100Services" in both code and config file together.
<ServiceContract()>
Public Interface IESM01100BankAccServices
    Inherits R_IServicebase(Of ESM01100BankAccDTO)

End Interface
