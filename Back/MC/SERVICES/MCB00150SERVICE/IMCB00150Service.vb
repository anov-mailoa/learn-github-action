Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB00150Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB00150Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCB00150Service

    <OperationContract()>
    Sub DoWork()

End Interface
