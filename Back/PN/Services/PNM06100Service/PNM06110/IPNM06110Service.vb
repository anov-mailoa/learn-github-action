Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM06110Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM06110Service
    Inherits R_IServicebase(Of PNM06110DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSettingDate(poParam As PNM06110DTO) As PNM06110DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecord(poParam As PNM06110DTO) As PNM06110DTO

End Interface
