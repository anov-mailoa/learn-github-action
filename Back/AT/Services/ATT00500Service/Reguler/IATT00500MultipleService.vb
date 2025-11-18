Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00500MultipleService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00500MultipleService
    Inherits R_IServicebase(Of ATT00500MultipleDTO)
    <OperationContract()>
    Sub DoWork()


End Interface
