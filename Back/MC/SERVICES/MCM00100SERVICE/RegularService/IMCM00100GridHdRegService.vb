Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM00100Back

<ServiceContract()>
Public Interface IMCM00100GridHdRegService
    Inherits R_IServicebase(Of MCM00100FormHdDto)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Activate(poParam As MCM00100FormHdDto) As MCM00100FormHdDto

End Interface
