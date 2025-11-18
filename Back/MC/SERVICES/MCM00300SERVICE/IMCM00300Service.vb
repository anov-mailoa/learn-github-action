Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM00300Service
    Inherits R_IServicebase(Of MCM00300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogRecord(poParam As MCM00300DTO) As MCM00300DTO
End Interface
