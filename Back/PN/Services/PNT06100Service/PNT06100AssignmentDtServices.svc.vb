Imports R_Common
Imports PNT06100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT06100AssignmentDtServices" in code, svc and config file together.
Public Class PNT06100AssignmentDtServices
    Implements IPNT06100AssignmentDtServices
    Public Sub Svc_R_Delete(poEntity As PNT06100Back.PNT06100AssignmentDtDto) Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentDtDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentDtCls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT06100Back.PNT06100AssignmentDtDto) As PNT06100Back.PNT06100AssignmentDtDto Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentDtDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentDtCls
        Dim loRtn As New PNT06100AssignmentDtDto
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT06100Back.PNT06100AssignmentDtDto, poCRUDMode As R_Common.eCRUDMode) As PNT06100Back.PNT06100AssignmentDtDto Implements R_BackEnd.R_IServicebase(Of PNT06100Back.PNT06100AssignmentDtDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentDtCls
        Dim loRtn As New PNT06100AssignmentDtDto
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As PNT06100Back.PNT06100AssignmentDtDto) Implements IPNT06100AssignmentDtServices.Dummy

    End Sub

    Public Function getQuantity(poParam As PNT06100AssignmentDtDto) As Integer Implements IPNT06100AssignmentDtServices.getQuantity
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentDtCls
        Dim loRtn As New Integer
        Try


            loRtn = loCls.getQuantity(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getAssetNo(poParam As PNT06100Back.PNT06100AssignmentDtDto) As Integer Implements IPNT06100AssignmentDtServices.getAssetNo
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentDtCls
        Dim loRtn As Integer
        Try
            loRtn = loCls.getAssetNo(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getSerialNo(poParam As PNT06100Back.PNT06100AssignmentDtDto) As Integer Implements IPNT06100AssignmentDtServices.getSerialNo
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentDtCls
        Dim loRtn As Integer
        Try
            loRtn = loCls.getSerialNo(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getSize(poParam As PNT06100Back.PNT06100AssignmentDtDto) As Integer Implements IPNT06100AssignmentDtServices.getSize
        Dim loEx As New R_Exception
        Dim loCls As New PNT06100AssignmentDtCls
        Dim loRtn As Integer
        Try
            loRtn = loCls.getSize(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
