Imports System.ServiceModel
Imports R_Common
Imports PNM14000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14000Service
    Inherits R_IServicebase(Of PNM14000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekExistKode(poParam As String) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckFlagUpload() As Boolean

End Interface
