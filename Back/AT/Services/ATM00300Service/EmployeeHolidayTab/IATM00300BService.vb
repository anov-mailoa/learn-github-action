Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00300BService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00300BService
    Inherits R_IServicebase(Of ATM00300BDTO)

    <OperationContract()>
    Sub DoWork()

End Interface
