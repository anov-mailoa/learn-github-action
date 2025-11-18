Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT00100DtService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT00100DtService
    Inherits R_IServicebase(Of MCT00100DtDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeLimitSubitem(poParam As MCT00100DtDTO) As MCT00100DtDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidateAvailable(poParam As MCT00100DtDTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkMedicalThreshold(poParam As MCT00100DtDTO) As MCT00100DtDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLimitInfo(poParam As MCT00100DtDTO) As MCT00100DtDTO
End Interface
