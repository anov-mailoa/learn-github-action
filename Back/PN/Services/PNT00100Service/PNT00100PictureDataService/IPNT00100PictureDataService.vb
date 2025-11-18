Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100PictureDataService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100PictureDataService
    Inherits R_IServicebase(Of PNT00100PictureDataDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPictureData(ByVal poParameter As PNT00100PictureDataDTO) As PNT00100PictureDataDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub savePicture(ByVal poParameter As PNT00100PictureDataDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub removePicture(ByVal poParameter As PNT00100PictureDataDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveSignature(ByVal poParameter As PNT00100PictureDataDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub removeSignature(ByVal poParameter As PNT00100PictureDataDTO)

End Interface
