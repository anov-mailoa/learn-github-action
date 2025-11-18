Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports GSM00600Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00600Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00600Service
    Inherits R_IServicebase(Of GSM00600DTO)


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub CekSoftPeriod(pcCompId As String, pcUserId As String)
End Interface
