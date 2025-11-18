Imports System.ServiceModel
Imports SAM01600Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01600Service" in both code and config file together.
<ServiceContract()>
Public Interface ISAM01600Service

    ' <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    ' Function GetServerNameCurrent() As List(Of ServerDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub CheckCompany(poParam As ParameterDTO)

    ' <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    ' Sub BackupSource(pcPath As String)
End Interface
