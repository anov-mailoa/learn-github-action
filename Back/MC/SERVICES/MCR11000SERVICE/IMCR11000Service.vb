Imports System.ServiceModel
Imports R_Common
Imports MCR11000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR11000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCR11000Service
    Inherits R_IServicebase(Of MCR11000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkDB(poParam As MCR11000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalYear(poParam As MCR11000DTO) As String

End Interface
