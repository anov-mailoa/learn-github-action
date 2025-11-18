Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT07250Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07250Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07250Service

    Inherits R_IServicebase(Of PNT07250DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidate(ByVal poParameter As PNT07250DTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateDelete(ByVal poParameter As PNT07250DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateAdd(ByVal poParameter As PNT07250DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT07250DTO) As PNT07250DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT07250DTO) As PNT07250DTO

End Interface
