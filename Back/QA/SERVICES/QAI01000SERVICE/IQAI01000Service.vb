Imports System.ServiceModel
Imports R_Common
Imports QAI01000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAI01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAI01000Service

    Inherits R_IServicebase(Of QAI01000DTO)

End Interface
