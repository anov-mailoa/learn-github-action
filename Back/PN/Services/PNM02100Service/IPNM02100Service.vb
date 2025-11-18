Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02100Service
    Inherits R_IServicebase(Of PNM02100ScoreGroupsDTO)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkDetail(poParam As PNM02100ScoreGroupsDTO) As Boolean

End Interface
