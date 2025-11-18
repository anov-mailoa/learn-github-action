Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCT02100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT02100PartnerService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT02100PartnerService
    Inherits R_IServicebase(Of MCT02100DetailGvDto)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DownloadValidation(poParam As MCT02100DetailGvDto)
   
End Interface
