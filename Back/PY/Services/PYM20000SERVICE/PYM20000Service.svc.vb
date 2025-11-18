Imports R_Common
Imports PYM20000BACK

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM20000Service" in code, svc and config file together.
Public Class PYM20000Service
    Implements IPYM20000Service

    Public Sub Svc_R_Delete(poEntity As PYM20000BACK.PYM20000DTO) Implements R_BackEnd.R_IServicebase(Of PYM20000BACK.PYM20000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM20000BACK.PYM20000DTO) As PYM20000BACK.PYM20000DTO Implements R_BackEnd.R_IServicebase(Of PYM20000BACK.PYM20000DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loRtn As PYM20000DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM20000BACK.PYM20000DTO, poCRUDMode As R_Common.eCRUDMode) As PYM20000BACK.PYM20000DTO Implements R_BackEnd.R_IServicebase(Of PYM20000BACK.PYM20000DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loRtn As PYM20000DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DeleteEmployee(poParam As PYM20000BACK.PYM20000DTO) Implements IPYM20000Service.DeleteEmployee
        Dim loCls As New PYM20000Cls
        Dim loEx As New R_Exception

        Try
            loCls.DeleteEmployee(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub ProcessAddEmployee(poParam As PYM20000BACK.PYM20000DTO) Implements IPYM20000Service.ProcessAddEmployee
        Dim loCls As New PYM20000Cls
        Dim loEx As New R_Exception

        Try
            loCls.ProcessAddEmployee(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetMinMaxOrgLvl(poParam As PYM20000BACK.PYM20000DTO) As PYM20000BACK.PYM20000DTO Implements IPYM20000Service.GetMinMaxOrgLvl
        Dim loException As New R_Exception
        Dim loCls As New PYM20000Cls
        Dim loRtn As New PYM20000DTO

        Try
            loRtn = loCls.GetMinMaxOrgLvl(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
