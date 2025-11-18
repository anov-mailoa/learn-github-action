Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCT01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT01000Service

    Inherits R_IServicebase(Of MCT01000DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmLimitPolicy(pcCompId As String) As MCT01000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmMedicalRestriction(pcCompId As String) As MCT01000DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As MCT01000DTO) As MCT01000DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As MCT01000DTO) As MCT01000DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckEmployeeMedicalBank(poParam As MCT01000DTO) As String

End Interface
