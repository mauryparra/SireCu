Module Usuario

    Public Class SampleIPrincipal
        Implements System.Security.Principal.IPrincipal

        Private identityValue As SampleIIdentity

        Public ReadOnly Property Identity() As System.Security.Principal.IIdentity Implements System.Security.Principal.IPrincipal.Identity
            Get
                Return identityValue
            End Get
        End Property

        Public Function IsInRole(ByVal role As String) As Boolean Implements System.Security.Principal.IPrincipal.IsInRole
            Return role = identityValue.Role.ToString
        End Function

        Public Sub New(ByVal name As String, ByVal password As String)
            identityValue = New SampleIIdentity(name, password)
        End Sub

    End Class

    Public Class SampleIIdentity
        Implements System.Security.Principal.IIdentity

        Private nameValue As String
        Private authenticatedValue As Boolean
        Private roleValue As ApplicationServices.BuiltInRole

        Public ReadOnly Property AuthenticationType As String Implements System.Security.Principal.IIdentity.AuthenticationType
            Get
                Return "SqlCEDatabase"
            End Get
        End Property

        Public ReadOnly Property IsAuthenticated As Boolean Implements System.Security.Principal.IIdentity.IsAuthenticated
            Get
                Return authenticatedValue
            End Get
        End Property

        Public ReadOnly Property Name As String Implements System.Security.Principal.IIdentity.Name
            Get
                Return nameValue
            End Get
        End Property

        Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
            Get
                Return roleValue
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal password As String)
            ' Contraseña es Case Sensitive, el Usuario no lo es
            If IsValidNameAndPassword(name, password) Then
                nameValue = name
                authenticatedValue = True
            Else
                nameValue = ""
                authenticatedValue = False
            End If

        End Sub

        Private Function IsValidNameAndPassword(ByVal username As String, ByVal password As String) As Boolean

            ' Look up the stored hashed password and salt for the username.
            Dim storedHashedPW As String = GetHashedPassword(username)
            Dim salt As String = GetSalt(username)

            'Create the salted hash.
            Dim rawSalted As String = salt & Trim(password)
            Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
            Dim sha512 As New System.Security.Cryptography.SHA512CryptoServiceProvider
            Dim hashedPwBytes() As Byte = sha512.ComputeHash(saltedPwBytes)
            Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)

            ' Compare the hashed password with the stored password.
            Return hashedPw = storedHashedPW

        End Function


    End Class

    Friend Function GetHashedPassword(ByVal username As String) As String
        ' Code that gets the user's hashed password

        Dim sql As String = "SELECT contraseña FROM Usuarios WHERE usuario = '" & username & "'"
        Dim dt As DataTable = consultarReader(sql)

        If dt.Rows.Count = 0 Then
            Return ""
        Else
            Return dt.Rows(0).Item("contraseña")
        End If
    End Function

    Friend Function GetSalt(ByVal username As String) As String
        ' Code that gets the user's salt

        Dim sql As String = "SELECT salt FROM Usuarios WHERE usuario = '" & username & "'"
        Dim dt As DataTable = consultarReader(sql)

        If dt.Rows.Count = 0 Then
            Return ""
        Else
            Return dt.Rows(0).Item("salt")
        End If
    End Function

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New System.Text.StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function CreateHashedPassword(ByVal contraseña As String, ByVal salt As String) As String

        'Create the hashed password.
        Dim rawSalted As String = salt & Trim(contraseña)
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha512 As New System.Security.Cryptography.SHA512CryptoServiceProvider
        Dim hashedPwBytes() As Byte = sha512.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)

        Return hashedPw
    End Function

    Public Function tipoDeUsuario(ByVal user As String)

        Dim sql As String = "SELECT * FROM Usuarios WHERE usuario = '" & user & "'"
        Dim dt As DataTable = consultarReader(sql)

        Return (dt.Rows(0).Item("rol"))

    End Function

End Module
