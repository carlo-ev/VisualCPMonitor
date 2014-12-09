Public Class deviceSummary

    Private Sub deviceSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAudio.Text = My.Computer.Audio.GetType.Module.Name
        lblFileSystem.Text = My.Computer.FileSystem.Drives.First.Name
        lblKeyboard.Text = My.Computer.Keyboard.GetType.Module.Name
        lblMouse.Text = My.Computer.Mouse.GetType.Module.Name
        lblPcName.Text = My.Computer.Name
        lblNetwork.Text = My.Computer.Network.GetType.Module.Name
        lblScreen.Text = My.Computer.Screen.DeviceName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New mainMenu)
    End Sub
End Class
