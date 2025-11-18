Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM01102Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM01102Service
    Inherits R_IServicebase(Of MCM01102Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ContractEmployee(poParam As MCM01102Dto) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogRecord(poParam As MCM01102Dto) As MCM01102Dto
End Interface
