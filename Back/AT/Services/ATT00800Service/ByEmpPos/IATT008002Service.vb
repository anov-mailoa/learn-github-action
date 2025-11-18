Imports ATT00800Back
Imports R_BackEnd
Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT008002Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT008002Service

    Inherits R_IServicebase(Of ATT008002DTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub prosesSaveAsDraft(ByVal poParam As ATT008002DTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub prosesSave(ByVal poParam As ATT008002DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpWorkGroupDesc(ByVal poParam As ATT008002DTO) As ATT008002DTO


    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpReasonDesc(ByVal poParam As ATT008002DTO) As ATT008002DTO

    '   <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Function getShiftCode(ByVal poParam As ATT008002DTO) As List(Of ATT008002DTO)

End Interface
