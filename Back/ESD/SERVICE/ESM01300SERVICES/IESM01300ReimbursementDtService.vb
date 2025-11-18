Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ESM01300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01300ReimbursementDtService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01300ReimbursementDtService
   Inherits R_IServicebase(Of ESM01300ReimbursementDtDTO)

End Interface
