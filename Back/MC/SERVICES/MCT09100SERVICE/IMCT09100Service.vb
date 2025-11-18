Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports MCT09100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT09100Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT09100Service

    Inherits R_IServicebase(Of MCT09100Dto)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataYear(ByVal pcCompanyId As String) As MCT09100Dto

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckAllowPremi(ByVal pcCompanyId As String) As Integer

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataForm(ByVal pcCompanyId As String, ByVal pcCyear As String, ByVal pcCdeptCode As String, ByVal pcCreferenceNo As String, ByVal pcUserId As String) As MCT09100Dto

End Interface
