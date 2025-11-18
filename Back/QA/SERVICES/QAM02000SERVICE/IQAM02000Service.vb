Imports System.ServiceModel
Imports R_Common
Imports QAM02000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAM02000Service

    Inherits R_IServicebase(Of QAM02000DTO)


    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateFlag(poParam As QAM02000DTO)


    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetViewTemplate(poParam As QAM02000DTO) As QAM02000DTO
End Interface
