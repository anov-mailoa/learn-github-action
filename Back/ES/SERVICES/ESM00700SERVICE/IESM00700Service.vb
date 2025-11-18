Imports System.ServiceModel
Imports ESM00700Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGST0200Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00700Service
    Inherits R_IServicebase(Of ESM00700DTO)

    <OperationContract(Action:="sSetPasswordExpired", ReplyAction:="sSetPasswordExpired")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub sSetPasswordExpired(poParam As ESM00700DTO)
End Interface
