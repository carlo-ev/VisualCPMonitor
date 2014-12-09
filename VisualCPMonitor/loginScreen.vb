Public Class loginScreen

    Private users()() As String = {New String() {"root", "root"}, New String() {"guest", "guest"}}
    Private userCount As Integer = 2

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = loginUsername.Text
        Dim password = loginPassword.Text
        If Not username.CompareTo("") And Not password.CompareTo("") Then
            loginUsername.Clear()
            loginPassword.Clear()
            For counter As Integer = 0 To users.Count - 1
                Dim reg = users(counter)
                If reg(0).CompareTo(username) And reg(1).CompareTo(password) Then
                    My.Forms.mainWindow.Controls.RemoveByKey("LoginScreen1")
                    My.Forms.mainWindow.Controls.Add(New mainMenu)
                End If
            Next counter
        End If

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim username = signupUsername.Text
        Dim password = signupPassword.Text
        Dim retype = signupRetype.Text
        If Not username.CompareTo("") And Not password.CompareTo("") Then
            If password.CompareTo(retype) Then
                signupUsername.Clear()
                signupPassword.Clear()
                signupRetype.Clear()
                userCount += 1
                users(userCount) = New String() {username, password}
            End If
        End If
    End Sub
End Class
