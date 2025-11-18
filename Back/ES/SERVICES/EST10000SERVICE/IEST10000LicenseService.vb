Imports System.ServiceModel
Imports R_Common
Imports EST10000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEST10000LicenseService" in both code and config file together.
<ServiceContract()>
Public Interface IEST10000LicenseService
    Inherits R_IServicebase(Of EST10000LicenceDataDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ApprovalLicenceData(poParam As EST10000LicenceDataDTO)
End Interface
