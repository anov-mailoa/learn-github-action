Imports System.ServiceModel
Imports ATB00700Back
Imports R_Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00700Service" in both code and config file together.
<ServiceContract()>
Public Interface IATB00700Service
    Inherits R_IServicebase(Of ATB00700DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getActualDt(ByVal pcCompId As String) As ATB00700DTO
End Interface
