Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATM00700Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00700AdditionalService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00700AdditionalService
    Inherits R_IServicebase(Of ATM00700AdditionalDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAdditionalLeave(pcCompId As String, pcUserId As String) As List(Of ATM00700AdditionalDTO)

End Interface
