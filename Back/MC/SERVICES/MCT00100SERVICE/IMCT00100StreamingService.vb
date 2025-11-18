Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT00100StreamingService
    <OperationContract(Action:="GetMedicalClaimList", ReplyAction:="GetMedicalClaimList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalClaimList() As Message

    <OperationContract(Action:="GetMedicalSubItemList", ReplyAction:="GetMedicalSubItemList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalSubItemList() As Message

    <OperationContract(Action:="GetCMBMedicalSubItem", ReplyAction:="GetCMBMedicalSubItem")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCMBMedicalSubItem() As Message

    <OperationContract(Action:="GetCMBMedicalInstitution", ReplyAction:="GetCMBMedicalInstitution")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCMBMedicalInstitution() As Message

    <OperationContract(Action:="GetCMBMedicalItem", ReplyAction:="GetCMBMedicalItem")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCMBMedicalItem() As Message

    <OperationContract(Action:="GetCMBCurrency", ReplyAction:="GetCMBCurrency")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCMBCurrency() As Message


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poGridHd As MCT00100GridHdDTO,
              ByVal poGridDt As MCT00100GridDtDTO)

End Interface
