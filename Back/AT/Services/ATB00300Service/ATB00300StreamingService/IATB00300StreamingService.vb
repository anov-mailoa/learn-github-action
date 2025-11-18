Imports System.ServiceModel
Imports ATB00300Back
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATB00300StreamingService

    <OperationContract()>
    Sub DoWork()

End Interface
