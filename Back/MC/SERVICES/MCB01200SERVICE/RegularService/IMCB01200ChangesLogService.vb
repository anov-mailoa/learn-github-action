Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB01200Back

<ServiceContract()>
Public Interface IMCB01200ChangesLogService
    Inherits R_IServicebase(Of MCB01200ChangesLogDto)

End Interface
