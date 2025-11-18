Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05210Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05210Service
    Inherits R_IServicebase(Of PNM05210DTO)


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProbationNotes(poEntity As PNM05210DTO) As String

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBlacklistNote(poEntity As PNM05210DTO) As String


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getChangePersonalData(poEntity As PNM05210DTO) As Boolean


End Interface
