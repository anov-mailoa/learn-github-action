Imports System.ServiceModel
Imports R_Common
Imports QAT00700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00700Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00700Service
    Inherits R_IServicebase(Of QAT00700Dto)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSocializationInfoProcess(poParam As QAT00700Dto) As QAT00700Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSystemParameter(poParam As QAT00700Dto) As QAT00700Dto
End Interface
