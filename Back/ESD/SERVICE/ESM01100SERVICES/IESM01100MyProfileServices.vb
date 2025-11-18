Imports System.ServiceModel
Imports R_Common
Imports ESM01100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01100Services" in both code and config file together.
<ServiceContract()>
Public Interface IESM01100MyProfileServices
    Inherits R_IServicebase(Of ESM01100MyProfileDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar2 As List(Of ESM01100ParamDTO))

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOfficialData(poParam As ESM01100MyProfileDTO) As ESM0110OfficialDataDTO

End Interface
