Imports R_Common
Imports PNT06100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06100EmployeeFacilitiesService" in code, svc and config file together.
Public Class PNT06100EmployeeFacilitiesService
    Implements IPNT06100EmployeeFacilitiesService


    Public Sub Svc_R_Delete(poEntity As PNT06100Back.PNT06100AssignmentHdDto) Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentHdDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT06100Back.PNT06100AssignmentHdDto) As PNT06100Back.PNT06100AssignmentHdDto Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentHdDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100EmployeeFacilitiesCls
        Dim loRtn As New PNT06100AssignmentHdDto
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT06100Back.PNT06100AssignmentHdDto, poCRUDMode As R_Common.eCRUDMode) As PNT06100Back.PNT06100AssignmentHdDto Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentHdDto).Svc_R_Save

    End Function

    Public Function Activate(poParam As PNT06100Back.PNT06100AssignmentHdDto) As PNT06100Back.PNT06100AssignmentHdDto Implements IPNT06100EmployeeFacilitiesService.Activate

    End Function
End Class
