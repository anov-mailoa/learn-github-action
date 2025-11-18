Imports R_BackEnd
Imports R_Common
Imports ATB00800Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports ATT00100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00800Service" in both code and config file together.
<ServiceContract()>
Public Interface IATB00800Service
    Inherits R_IServicebase(Of ATB00800DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poCurrent As ATB00800DTO) As ATB00800DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpWorkGroupDesc(poCurrent As ATB00800DTO) As String

End Interface
