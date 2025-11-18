Imports R_BackEnd
Imports R_Common
Imports MCB01100Back
Imports System.ServiceModel

<ServiceContract()>
Public Interface IMCB01100MedicalItemLimitService
    Inherits R_IServicebase(Of MCB01100MedicalItemLimitDto)

End Interface
