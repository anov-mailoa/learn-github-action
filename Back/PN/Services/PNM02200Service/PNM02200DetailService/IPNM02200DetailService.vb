Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02200DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02200DetailService
    Inherits R_IServicebase(Of PNM02200FormDTO)


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getActive(poParam As PNM02200FormDTO) As PNM02200FormDTO

End Interface
