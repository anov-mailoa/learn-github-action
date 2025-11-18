Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100JobDescService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100JobDescService

    Inherits R_IServicebase(Of PNM03100JobDescDTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getJobDesc(poParam As PNM03100JobDescDTO) As PNM03100JobDescDTO

End Interface
