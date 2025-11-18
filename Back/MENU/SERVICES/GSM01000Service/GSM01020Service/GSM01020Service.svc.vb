Imports R_Common
Imports GSM01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM01020Service" in code, svc and config file together.
Public Class GSM01020Service
    Implements IGSM01020Service

    Public Sub Svc_R_Delete(poEntity As GSM01000Back.GSM01020DTO) Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01020DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM01020Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM01000Back.GSM01020DTO) As GSM01000Back.GSM01020DTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01020DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As GSM01020DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM01000Back.GSM01020DTO, poCRUDMode As R_Common.eCRUDMode) As GSM01000Back.GSM01020DTO Implements R_BackEnd.R_IServicebase(Of GSM01000Back.GSM01020DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As GSM01020DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDept(poParam As GSM01000Back.GSM01020DTO) As System.Collections.Generic.List(Of GSM01000Back.GSM01020CmbDTO) Implements IGSM01020Service.getCmbDept
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As List(Of GSM01020CmbDTO)

        Try
            loRtn = loCls.getCmbDept(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekDeptSamUser(poParam As GSM01000Back.GSM01020DTO) As Boolean Implements IGSM01020Service.cekDeptSamUser
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekDeptSamUser(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekSequence(poParam As GSM01000Back.GSM01020DTO) As Boolean Implements IGSM01020Service.cekSequence
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekSequence(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekUserId(poParam As GSM01000Back.GSM01020DTO) As Boolean Implements IGSM01020Service.cekUserId
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekUserId(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function cekDeptMode(poParam As GSM01000Back.GSM01020DTO) As Boolean Implements IGSM01020Service.cekDeptMode
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.cekDeptMode(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbDepartmentDESC(poParam As GSM01000Back.GSM01020DTO) As String Implements IGSM01020Service.getCmbDepartmentDESC

        Dim loEx As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As String
        Dim loRtnTemp As List(Of GSM01020CmbDTO)

        Try
            loRtnTemp = loCls.getCmbDept(poParam)

            Dim loQuery = From A In loRtnTemp
                            Where A.cCode.Trim = poParam.cDeptCode.Trim
                            Select A.cDesc

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function getMaxSeq(poParam As GSM01000Back.GSM01020DTO) As Integer Implements IGSM01020Service.getMaxSeq
        Dim loException As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getMaxSeq(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub saveApprovalSequence(poParam As System.Collections.Generic.List(Of GSM01000Back.GSM01020DTO)) Implements IGSM01020Service.saveApprovalSequence
        Dim loEx As New R_Exception
        Dim loCls As New GSM01020Cls
        Try
            loCls.saveApprovalSequence(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GSL00300DESC(poParam As GSM01000Back.GSM01020DTO) As GSM01000Back.GSM01020UserAppDTO Implements IGSM01020Service.GSL00300DESC
        Dim loEx As New R_Exception
        Dim loCls As New GSM01020Cls
        Dim loRtn As GSM01020UserAppDTO
        Dim loRtnTemp As List(Of GSM01020UserAppDTO)

        Try
            loRtnTemp = loCls.getListUserDesc(poParam)

            Dim loQuery = From A In loRtnTemp
                            Where A.cUserId.Trim = poParam.cSelectedUser.Trim
                            Select A

            loRtn = loQuery.FirstOrDefault
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
       
    End Function
End Class
