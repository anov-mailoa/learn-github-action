Imports R_Common
Imports PNT06200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06200EmployeeFacilitiesServices" in code, svc and config file together.
Public Class PNT06200EmployeeFacilitiesServices
    Implements IPNT06200EmployeeFacilitiesServices



    Public Sub Svc_R_Delete(poEntity As PNT06200Back.PNT06200ReturnHdDto) Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnHdDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT06200Back.PNT06200ReturnHdDto) As PNT06200Back.PNT06200ReturnHdDto Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnHdDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT06200EmployeeFacilitiesCls
        Dim loRtn As New PNT06200ReturnHdDto
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT06200Back.PNT06200ReturnHdDto, poCRUDMode As R_Common.eCRUDMode) As PNT06200Back.PNT06200ReturnHdDto Implements R_BackEnd.R_IServicebase(Of PNT06200Back.PNT06200ReturnHdDto).Svc_R_Save

    End Function

    Public Function Activate(poParam As PNT06200Back.PNT06200ReturnHdDto) As PNT06200Back.PNT06200ReturnHdDto Implements IPNT06200EmployeeFacilitiesServices.Activate

    End Function
End Class
