Imports R_Common
Imports ESI00100Back
Imports ESI00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESI00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESI00100Service
    Inherits R_IServicebase(Of ESI00100DTO)

    <OperationContract(Action:="getOfficialInfo", ReplyAction:="getOfficialInfo")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOfficialInfo(poParam As ESI00100DTO) As ESI00100DTO

    <OperationContract(Action:="getTransaction", ReplyAction:="getTransaction")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction(poParam As ESI00100DTO) As ESI00100DTO

    <OperationContract(Action:="getAbsencePresentLeave", ReplyAction:="getAbsencePresentLeave")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAbsencePresentLeave(poParam As ESI00100DTO) As ESI00100DTO

    <OperationContract(Action:="getAttendanceInfo", ReplyAction:="getAttendanceInfo")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAttendanceInfo(poParam As ESI00100DTO) As ESI00100DTO

    <OperationContract(Action:="saveNewPassword", ReplyAction:="saveNewPassword")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveNewPassword(poParam As ESI00100DTO)

    <OperationContract(Action:="changePhoto", ReplyAction:="changePhoto")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub changePhoto(poParam As ESI00100DTO)

    <OperationContract(Action:="checkPassword", ReplyAction:="checkPassword")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPassword(poParam As ESI00100DTO) As Integer

End Interface
