Imports System.ServiceModel
Imports R_Common
Imports QAT01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT01000Service
    Inherits R_IServicebase(Of QAT01000DTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Sub doUploadDocument(poParam As QAT01000DTO)

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Sub doUploadSource(poParam As QAT01000DTO)

End Interface
