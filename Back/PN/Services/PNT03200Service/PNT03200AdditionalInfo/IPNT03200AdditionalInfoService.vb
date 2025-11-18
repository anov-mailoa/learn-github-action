Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03200AdditionalInfoService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03200AdditionalInfoService
    Inherits R_IServicebase(Of PNT03200AdditionalInfoDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidate(poParam As PNT03200AdditionalInfoDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateDelete(poParam As PNT03200AdditionalInfoDTO)

End Interface
