Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05200MedicalHistoryService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05200MedicalHistoryService
    Inherits R_IServicebase(Of PNM05200MedicalHistoryDTO)




End Interface
