Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT006002Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT006002Service
    Inherits R_IServicebase(Of QAT006002DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidationBatch(ByVal poParam As QAT006002DTO) As Boolean

End Interface
