Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03200PictureDataService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03200PictureDataService

    Inherits R_IServicebase(Of PNT03200PictureDataDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPictureData(ByVal poParameter As PNT03200PictureDataDTO) As PNT03200PictureDataDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub savePicture(ByVal poParameter As PNT03200PictureDataDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub removePicture(ByVal poParameter As PNT03200PictureDataDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveSignature(ByVal poParameter As PNT03200PictureDataDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub removeSignature(ByVal poParameter As PNT03200PictureDataDTO)

End Interface
