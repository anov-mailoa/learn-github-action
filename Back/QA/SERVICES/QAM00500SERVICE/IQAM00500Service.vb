Imports System.ServiceModel
Imports R_Common
Imports QAM00500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00500Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00500Service
    Inherits R_IServicebase(Of QAM00500Dto)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetParameter(poParam As QAM00500Dto) As QAM00500Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetAlreadyUsed(poParam As QAM00500Dto) As QAM00500Dto
End Interface
