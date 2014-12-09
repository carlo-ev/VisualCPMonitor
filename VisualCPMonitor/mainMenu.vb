Public Class mainMenu

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOs.Text = My.Computer.Info.OSFullName
        lblPlatform.Text = My.Computer.Info.OSPlatform
        lblVersion.Text = My.Computer.Info.OSVersion
        lblPhysical.Text = My.Computer.Info.TotalPhysicalMemory & " Bytes"
        lblPhysicalGB.Text = My.Computer.Info.TotalPhysicalMemory / 1000000000 & " GB"
        lblVirtual.Text = My.Computer.Info.TotalVirtualMemory & " Bytes"
        lblVirtualGB.Text = My.Computer.Info.TotalVirtualMemory / 1000000000 & " GB"
        lblPhysicalAvailable.Text = My.Computer.Info.AvailablePhysicalMemory & " Bytes"
        lblPhysicalAvailableGB.Text = My.Computer.Info.AvailablePhysicalMemory / 1000000000 & " GB"
        lblVirtualAvailable.Text = My.Computer.Info.AvailableVirtualMemory & " Bytes"
        lblVirtualAvailableGB.Text = My.Computer.Info.AvailableVirtualMemory / 1000000000 & " GB"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New loginScreen)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New detailedInfo)
    End Sub

    Private Sub btnDeviceSummary_Click(sender As Object, e As EventArgs) Handles btnDeviceSummary.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New deviceSummary)
    End Sub
End Class
