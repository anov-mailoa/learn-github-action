Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00300DtService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00300DtService

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTemplate(poParam As List(Of PYT00300DtDTO), pcKey As String) As List(Of PYT00300DtDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckIfExistDownload(poParam As PYT00300DtDTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckIfExistUpload(poParam As PYT00300DtDTO) As Boolean

    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Sub SaveBatchPyt00300Dt(poParam As List(Of PYT00300DtDTO), pcKey As String)
End Interface
