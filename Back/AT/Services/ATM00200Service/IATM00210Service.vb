Imports System.ServiceModel
Imports ATM00200Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00210Service" in both code and config file together.
<ServiceContract()>
Public Interface IATM00210Service

    Inherits R_IServicebase(Of ATM00210DTO)
    '<OperationContract()>
    'Sub DoWork()

End Interface
