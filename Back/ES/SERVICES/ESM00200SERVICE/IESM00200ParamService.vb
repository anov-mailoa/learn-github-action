Imports System.ServiceModel
Imports R_Common
Imports ESM00200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00200ParamService
    Inherits R_IServicebase(Of ESM00200ParamDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveESSReason(poParam As ESM00200ParamDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function UpdateReserveGeocoding(poParam As ESM00200ParamDTO) As ESM00200ParamDTO

End Interface
