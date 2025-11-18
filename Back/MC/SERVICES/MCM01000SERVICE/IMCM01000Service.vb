Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCM01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM01000Service
    Inherits R_IServicebase(Of MCM01000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckUserAuthority(poParam As MCM01000DTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub CopyPrevious(poParam As MCM01000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogRecord(poParam As MCM01000DTO) As MCM01000DTO
End Interface
