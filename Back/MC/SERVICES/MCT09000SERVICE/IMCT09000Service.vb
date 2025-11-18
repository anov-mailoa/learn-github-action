Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT09000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT09000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT09000Service
    Inherits R_IServicebase(Of MCT09000Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYear(pcCompId As String) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub CancelClaimProcess(ByRef poParam As MCT09000Dto)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckAllowCancel(ByVal pcCompanyId As String) As Integer
End Interface
