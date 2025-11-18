Imports R_Common
Imports ESSMenuBack
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESSMenuService" in code, svc and config file together.
Public Class ESSMenuService
    Implements IESSMenuService

    Public Function Login(poParam As ESSLoginDTO) As ESSMenuBack.ESSLoginDTO Implements IESSMenuService.Login
        Dim loException As New R_Exception
        Dim loCls As New ESSMenuCls
        Dim loRtn As ESSLoginDTO = Nothing
        Dim loAuthData As R_AuthenticationData

        Try
            loRtn = loCls.Login(poParam)

            'Prepare Internal Auth Data
            loAuthData = New R_AuthenticationData
            With loAuthData
                .TokenType = R_TokenHelper.TOKEN_TYPE_INTERNAL
                .UserID = poParam.CEMPLOYEE_ID.Trim
                .Password = poParam.CPASSWORD_LOGIN.Trim
                .ExpiredDays = 2
            End With
            'set Access Token
            R_Context._SetServerContext(R_InternalContextVarEnumerator.ACCESS_TOKEN, R_TokenHelper.GenerateTokenAccess(loAuthData))

            R_Context._SetServerContext(R_Context._GetKey(R_Context.eContextKey.EncryptKey), New String() {KeyEncryptor.KeyEncryptorClass.GetKeyEncryptor, KeyEncryptor.KeyEncryptorClass._Uyah})
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub SetKey(pcKey As String) Implements IESSMenuService.SetKey
        Dim loException As New R_Exception
        Dim loCls As New ESSMenuCls
        Dim loRtn As ESSLoginDTO = Nothing

        Try
            loCls.SetKey(pcKey)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub R_UserLockingFlush(pcCurrentCompanyId As String, pcUserId As String) Implements IESSMenuService.R_UserLockingFlush
        Dim loException As New R_Exception
        Dim loCls As New ESSMenuCls
        Dim loRtn As ESSLoginDTO = Nothing

        Try
            loCls.R_UserLockingFlush(pcCurrentCompanyId, pcUserId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetInfo() As System.Collections.Generic.List(Of ESSMenuBack.AboutDTO) Implements IESSMenuService.GetInfo
        Dim loException As New R_Exception
        Dim loCls As New ESSMenuCls
        Dim loRtn As List(Of AboutDTO) = Nothing

        Try
            loRtn = loCls.GetInfo
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub UpdatePassword(poParam As ESSMenuBack.ESSLoginDTO) Implements IESSMenuService.UpdatePassword
        Dim loException As New R_Exception
        Dim loCls As New ESSMenuCls

        Try
            loCls.UpdatePassword(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
