Imports R_BackEnd
Imports PNT06100Back
Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT06100AssignmentDtServices" in both code and config file together.
<ServiceContract()>
Public Interface IPNT06100AssignmentDtServices

    Inherits R_IServicebase(Of PNT06100AssignmentDtDto)


    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As PNT06100AssignmentDtDto)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getQuantity(poParam As PNT06100AssignmentDtDto) As Integer

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getAssetNo(poParam As PNT06100AssignmentDtDto) As Integer

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getSerialNo(poParam As PNT06100AssignmentDtDto) As Integer

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getSize(poParam As PNT06100AssignmentDtDto) As Integer

End Interface
