Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100BankAccService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100BankAccService
    Inherits R_IServicebase(Of PNT00100BankAccGridDTO)

    <OperationContract()>
    Sub DoWork()

End Interface
