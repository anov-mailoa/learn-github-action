Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00200Back
Imports System.ServiceModel.Channels
Imports ATT00200Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00200Service
    Inherits R_IServicebase(Of ATT00200DTO)


    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSchedule(poEntity As ATT00200DTO) As ATT00200DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poEntity As ATT00200DTO) As ATT00200DTO

End Interface
