Imports System.ServiceModel
Imports R_Common
Imports QAI01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAI01100Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAI01100Service
    Inherits R_IServicebase(Of QAI01100Dto)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSOCINFO(poParam As QAI01100Dto) As QAI01100Dto
End Interface
