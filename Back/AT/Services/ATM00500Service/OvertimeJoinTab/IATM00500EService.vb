Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00500EService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00500EService
    Inherits R_IServicebase(Of ATM00500EDTO)


    '   <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Function SaveBatch(pcCompId As String, poNewEntity As List(Of ATM00500EDTO), poCRUDMode As R_Common.eCRUDMode) As List(Of ATM00500EDTO)
End Interface
