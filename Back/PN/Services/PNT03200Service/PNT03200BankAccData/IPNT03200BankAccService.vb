Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100BankAccService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03200BankAccService
    Inherits R_IServicebase(Of PNT03200AccountDTO)

    <OperationContract()>
    Sub DoWork()

End Interface
