Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim usage As New PerformanceCounter("Processor", "% Processor Time", "_Total")
        cpuUsageText.Text = usage.NextValue() & "%"


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpuBar.Value = cpuCounter.NextValue.ToString
        lbl_cpuUsage.Text = "CPU Usage: " + cpuBar.Value.ToString + "%"

        Dim diskValue = diskCounter.NextValue
        diskBar.Value = If(diskValue <= 100, diskValue.ToString, "100")
        lbl_diskUsage.Text = "Disk Usage: " + diskBar.Value.ToString + "%"

        ramBar.Value = ramCounter.NextValue.ToString
        lbl_ramUsage.Text = "RAM Usage: " + ramBar.Value.ToString + "%"
    End Sub
End Class
