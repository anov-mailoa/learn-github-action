Imports System.ServiceModel
Imports R_Common
Imports PYB01900Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
Imports PYB01900Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB01900Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYB01900Service
    Inherits R_IServicebase(Of PYB01900DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_PYB01900_GET_PDF_PASSWORD(poParam As PYB01900SPTDTO) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_PYB01900_SAVE_SPT_FILE_EMP(poParam As PYB01900SPTDTO)

End Interface
