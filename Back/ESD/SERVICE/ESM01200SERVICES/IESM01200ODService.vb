Imports R_Common
Imports ESM01200Back
Imports ESM01200Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01200ODService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01200ODService
    Inherits R_IServicebase(Of ESM01200ODParamDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function cekExistTrx(poParam As ESM01200ODParamDTO) As String
End Interface
