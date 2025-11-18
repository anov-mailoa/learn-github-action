Imports System.ServiceModel
Imports R_Common
Imports PNM09000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM09000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM09000Service
    Inherits R_IServicebase(Of PNM09000DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckUser(poParam As PNM09000DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getAlertDays(poParam As PNM09000DTO) As PNM09000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function SaveAlertDays(poParam As PNM09000DTO) As PNM09000DTO

End Interface
