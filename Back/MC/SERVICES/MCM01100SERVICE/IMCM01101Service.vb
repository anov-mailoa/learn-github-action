Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM01101Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM01101Service
    Inherits R_IServicebase(Of MCM01101Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ComboMedicalItem(ByRef pcComId As String) As List(Of MCM01101ComboDto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function LimitPolicy(ByRef pcComId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogRecord(poParam As MCM01101Dto) As MCM01101Dto
End Interface
