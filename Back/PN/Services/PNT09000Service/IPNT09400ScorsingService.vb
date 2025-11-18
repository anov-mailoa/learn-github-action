Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09400ScorsingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09400ScorsingService

    Inherits R_IServicebase(Of PNT09400DTO)

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParams As List(Of PNT09400ReportDTO))

End Interface
