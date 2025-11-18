Imports System.ServiceModel
Imports R_Common
Imports GSM01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01100CompanyBankService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01100CompanyBankService

    Inherits R_IServicebase(Of GSM01100CompBankGridDTO)

End Interface
