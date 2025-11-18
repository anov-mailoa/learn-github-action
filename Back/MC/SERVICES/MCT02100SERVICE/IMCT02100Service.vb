Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCT02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM02100Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT02100Service
    Inherits R_IServicebase(Of MCT02100Dto)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYear(ByRef pcCompanyId As String) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function ReDraft(ByRef poParam As MCT02100Dto) As MCT02100Dto

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(ByRef poParam As MCT02100Dto) As MCT02100Dto
End Interface
