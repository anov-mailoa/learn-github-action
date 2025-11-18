Imports System.ServiceModel
Imports R_Common
Imports EST10000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEST10000PersonalDataService" in both code and config file together.
<ServiceContract()>
Public Interface IEST10000PersonalDataService
    Inherits R_IServicebase(Of EST10000PersonalDataDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ApprovalPesonalData(poParam As EST10000PersonalDataDTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetRecord(poParam As EST10000PersonalDataDTO) As EST10000PersonalDataDTO
End Interface
