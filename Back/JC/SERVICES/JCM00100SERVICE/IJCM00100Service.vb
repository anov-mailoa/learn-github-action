Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IJCM00100Service
    Inherits R_IServicebase(Of JCM00100DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMainData(pcCompId As String) As Integer

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecord(poEntity As JCM00100DTO) As JCM00100DTO
End Interface
