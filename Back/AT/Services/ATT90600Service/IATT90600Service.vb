Imports System.ServiceModel
Imports R_Common
Imports ATT90600Back
Imports ATT90600Common
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90600Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT90600Service

    Inherits R_IServicebase(Of ATT90600DTO)


    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As ATT90600DTO) As ATT90600DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As ATT90600DTO) As ATT90600DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListCompensatoryDetail(poParam As ATT90600DTO) As ATT90600DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListCompensatoryDetailHistory(poParam As ATT90600DTO) As ATT90600DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSystemParam(poParam As ATT90600DTO) As ATT90600DTO
     
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub deleteHeader(poParam As ATT90600DTO)

End Interface
