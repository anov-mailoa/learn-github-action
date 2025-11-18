' NOTE: You can use the "Rename" command on the context menu to change the class name "SAM02900Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select SAM02900Service.svc or SAM02900Service.svc.vb at the Solution Explorer and start debugging.
Imports R_Common
Imports SAM02900Back
Imports TelerikMenuService

Public Class SAM02900Service
    Implements ISAM02900Service

    Public Function EditMFA(poEntity As EditMfaDTO) As MfaDTO Implements ISAM02900Service.EditMFA
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtn As MfaDTO = Nothing

        Try
            loRtn = loCls.EditMFA(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub CheckMfaData(pcCompanyId As String) Implements ISAM02900Service.CheckMfaData
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls

        Try
            loCls.CheckMfaData(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetSecurityMFA(pcCompanyId As String) As MfaDTO Implements ISAM02900Service.GetSecurityMFA
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtn As MfaDTO = Nothing

        Try
            loRtn = loCls.GetSecurityMFA(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetMFAMode() As List(Of MfaModeDTO) Implements ISAM02900Service.GetMFAMode
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtn As List(Of MfaModeDTO) = Nothing

        Try
            loRtn = loCls.GetMFAMode()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function GetNonMFAUser(poEntity As MFAUserParameterDTO) As MFAUserDTO Implements ISAM02900Service.GetNonMFAUser
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtn As MFAUserDTO = Nothing

        Try
            loRtn = loCls.GetNonMFAUser(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SaveNonMFAUser(poEntity As SaveNonMFAUserDTO) As MFAUserDTO Implements ISAM02900Service.SaveNonMFAUser
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtn As MFAUserDTO = Nothing

        Try
            loRtn = loCls.SaveNonMFAUser(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DeleteNonMFAUser(poEntity As MFAUserParameterDTO) Implements ISAM02900Service.DeleteNonMFAUser
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls

        Try
            loCls.DeleteNonMFAUser(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetSecurityOnSite(pcCompanyId As String) As OnSiteDTO Implements ISAM02900Service.GetSecurityOnSite
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtn As OnSiteDTO = Nothing

        Try
            loRtn = loCls.GetSecurityOnSite(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function EditOnSite(poEntity As OnSiteDTO) As OnSiteDTO Implements ISAM02900Service.EditOnSite
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls
        Dim loRtn As OnSiteDTO = Nothing

        Try
            loRtn = loCls.EditOnSite(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub CheckOnSiteData(pcCompanyId As String) Implements ISAM02900Service.CheckOnSiteData
        Dim loEx As New R_Exception
        Dim loCls As New SAM02900Cls

        Try
            loCls.CheckOnSiteData(pcCompanyId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
